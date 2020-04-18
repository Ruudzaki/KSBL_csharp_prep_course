using System;
using System.Globalization;
using System.Windows.Forms;
using KSBL_CallWinForm.CallGeneratorFactory;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.CallModule;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm
{
    public delegate void RunCallGeneratorDelegate();

    public partial class CallViewer : Form
    {
        public RunCallGeneratorDelegate RunCallGenerator;

        public CallViewer(Mobile mobile, CallGenerator callGenerator)
        {
            InitializeComponent();

            Mobile = mobile;
            CallGenerator = callGenerator;

            MaximizeBox = false;
            InitializeEvents();
        }

        public Mobile Mobile { get; set; }
        public CallGenerator CallGenerator { get; set; }

        private void InitializeEvents()
        {
            Mobile.InternalStorage.CallAdded += ReceiveCallsFromDb;
            RunCallGenerator += CallGenerator.RunCallGenerator;
        }

        private void ReceiveCallsFromDb(object call)
        {
            if (InvokeRequired) Invoke(new CallAddedDelegate(ReceiveCallsFromDbHandler), call);
        }

        private void ReceiveCallsFromDbHandler(Call call)
        {
            if (Mobile.InternalStorage.Calls.Count > 0) ShowMessages();
        }

        private void ShowMessages()
        {
            CallListView.Items.Clear();

            var orderedGroupedCalls = Mobile.InternalStorage.GetUniqueLastAndTimeSortedCalls();

            foreach (var call in orderedGroupedCalls)
            {
                var equalCallCount = Mobile.InternalStorage.GetEqualCallCount(call);
                CallListView.Items.Add(new ListViewItem(new[]
                {
                    call.Contact.Name, call.CallType.ToString(), call.CallTime.ToString(CultureInfo.InvariantCulture),
                    equalCallCount.ToString()
                }));
            }
        }

        private void CallViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            CallGenerator.Stop();
        }

        private void CallViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CallGenerator.Stop();
        }

        private void runCallGeneratorButton_Click(object sender, EventArgs e)
        {
            if (CallGenerator.CallGeneratorIsOn)
            {
                CallGenerator.Stop();
            }
            else
            {
                var handler = RunCallGenerator;
                handler?.Invoke();
            }
        }
    }
}