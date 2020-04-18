using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public CallViewer(Mobile mobile, IOutput output, CallGenerator messageGenerator)
        {
            InitializeComponent();

            Mobile = mobile;
            CallGenerator = messageGenerator;
            Mobile.Output = output;

            MaximizeBox = false;
            InitializeEvents();

        }

        public event RunCallGeneratorDelegate RunCallGenerator;

        private void InitializeEvents()
        {
            Mobile.InternalStorage.CallAdded += ReceiveCallsFromDb;
            RunCallGenerator += CallGenerator.RunCallGenerator;

            var handler = RunCallGenerator;
            handler?.Invoke();
        }

        public Mobile Mobile { get; set; }
        public CallGenerator CallGenerator { get; set; }
        public List<Call> SelectedCalls { get; set; }



        private void ReceiveCallsFromDb(object call)
        {
            if (InvokeRequired) Invoke(new CallAddedDelegate(ReceiveCallsFromDbHandler), call);
        }

        private void ReceiveCallsFromDbHandler(Call call)
        {
            if (Mobile.InternalStorage.Calls.Count > 0)
            {
                ShowMessages(Mobile.InternalStorage.Calls);
            }
        }

        private void ShowMessages(IEnumerable<Call> calls)
        {
            CallListView.Items.Clear();


            SelectedCalls = Mobile.InternalStorage.Calls;

            foreach (var call in SelectedCalls)
            {
                CallListView.Items.Add(new ListViewItem(new string[] {call.PhoneNumber, call.CallType.ToString(), call.CallTime.ToString(CultureInfo.InvariantCulture)}));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
