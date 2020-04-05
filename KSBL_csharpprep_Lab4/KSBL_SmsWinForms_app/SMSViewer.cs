using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Mobile;
using Message = KSBL_Class_Library.Components.SmsModule.Message;
using Timer = System.Threading.Timer;

namespace KSBL_SmsWinForms_app
{
    public delegate void FormatChangedDelegate(List<Message> messages);

    public delegate void FilterChangedDelegate(List<Message> messages);

    public partial class SmsViewer : Form
    {
        private object _lock = new object();


        public SmsViewer(Mobile mobile, IOutput output, Message message1, Message message2, Message message3)
        {
            InitializeComponent();
            InitializeComboBoxes();

            Mobile = mobile;
            Mobile.Output = output;

            MaximizeBox = false;
            Timers = new List<Timer>();
            Formatter = Mobile.InternalStorage.Formatter;
            PickedUser = null;
            SearchText = "";
            StartWithDate = new DateTime();
            EndWithDate = new DateTime();

            MessageGenerator(message1, 0, 3000);
            MessageGenerator(message2, 0, 3500);
            MessageGenerator(message3, 0, 4000);

            Mobile.InternalStorage.SmsAdded += ReceiveMessagesFromDb;
            FormatChanged += ShowMessages;
            FilterChanged += ShowMessages;
        }

        public Mobile Mobile { get; }
        private List<Timer> Timers { get; }
        public FormatDelegate Formatter { get; set; }
        private IEnumerable<Message> SelectedMessages { get; set; }
        private string SearchText { get; set; }

        public string PickedUser { get; set; }

        public DateTime StartWithDate { get; set; }

        public DateTime EndWithDate { get; set; }

        public bool JoinFilteringCheck { get; set; }

        public event FormatChangedDelegate FormatChanged;
        public event FilterChangedDelegate FilterChanged;

        private void InitializeComboBoxes()
        {
            formatComboBox.Items.Add(Formats.None);
            formatComboBox.Items.Add(Formats.FormatStartWithDate);
            formatComboBox.Items.Add(Formats.FormatEndWithDate);
            formatComboBox.Items.Add(Formats.FormatUpperCase);
            formatComboBox.Items.Add(Formats.FormatLowerCase);
            formatComboBox.Items.Add(Formats.Custom);
        }

        public void MessageGenerator(Message message, int dueTime, int period)
        {
            TimerCallback tm = Mobile.InternalStorage.AddMessage;
            Timers.Add(new Timer(tm, message, dueTime, period));
        }

        private void ReceiveMessagesFromDb(object message)
        {
            if (InvokeRequired) Invoke(new SmsAddedDelegate(ReceiveMessagesFromDbHandler), message);
        }

        private void ReceiveMessagesFromDbHandler(Message message)
        {
            if (Mobile.InternalStorage.Messages.Count > 0)
            {
                ShowMessages(Mobile.InternalStorage.Messages);
                if (!UserComboBox.Items.Contains(Mobile.InternalStorage.UniqueUsers.Last()))
                {
                    UserComboBox.Items.Clear();
                    UserComboBox.Items.Add("");
                    UserComboBox.Items.AddRange(Mobile.InternalStorage.UniqueUsers.ToArray());
                }
            }
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (formatComboBox.SelectedIndex)
            {
                case 0:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatNone;
                    break;
                case 1:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatStartWithDate;
                    break;
                case 2:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatEndWithDate;
                    break;
                case 3:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatUpperCase;
                    break;
                case 4:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatLowerCase;
                    break;
                case 5:
                    Mobile.InternalStorage.Formatter = FormatterClass.FormatUpperStartWithDate;
                    break;
            }

            var handler = FormatChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }

        private void ShowMessages(IEnumerable<Message> messages)
        {
            MessageListView.Items.Clear();

            if (AllFilterOnCheckBox.Checked)
                SelectedMessages =
                    Mobile.InternalStorage.FilterAll(messages, PickedUser, SearchText, StartWithDate, EndWithDate);
            else
                SelectedMessages =
                    Mobile.InternalStorage.FilterSeparate(messages, PickedUser, SearchText, StartWithDate, EndWithDate);

            foreach (var message in SelectedMessages)
            {
                var formatMessage = Mobile.InternalStorage.FormatText(message);
                MessageListView.Items.Add(new ListViewItem(new[] {formatMessage.User, formatMessage.FormatText}));
            }
        }

        private void SmsViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var timer in Timers) timer.Dispose();
        }

        private void SmsViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var timer in Timers) timer.Dispose();
        }

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PickedUser = (string) UserComboBox.Items[UserComboBox.SelectedIndex];

            var handler = FilterChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchText = searchTextBox.Text;

            var handler = FilterChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }

        private void startWithDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            StartWithDate = startWithDateTimePicker.Value;

            var handler = FilterChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }


        private void endWithDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndWithDate = endWithDateTimePicker.Value;

            var handler = FilterChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }

        private void AllFilterOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            JoinFilteringCheck = AllFilterOnCheckBox.Checked;

            var handler = FilterChanged;
            handler?.Invoke(Mobile.InternalStorage.Messages);
        }
    }
}