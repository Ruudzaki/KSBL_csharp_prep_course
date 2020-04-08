using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.Storage;
using KSBL_Class_Library.Mobile;
using KSBL_SmsWinForms_app.Formatter;
using KSBL_SmsWinForms_app.MessageGenerator;
using Message = KSBL_Class_Library.Components.SmsModule.Message;

namespace KSBL_SmsWinForms_app
{
    public delegate void FormatChangedDelegate(List<Message> messages);

    public delegate void FilterChangedDelegate(List<Message> messages);

    public delegate void RunMessageGeneratorDelegate();

    public partial class SmsViewer : Form
    {
        private object _lock = new object();


        public SmsViewer(Mobile mobile, IOutput output, MessageGeneratorBasic messageGenerator)
        {
            InitializeComponent();
            InitializeComboBoxes();

            Mobile = mobile;
            MessageGenerator = messageGenerator;
            Mobile.Output = output;

            MaximizeBox = false;
            Formatter = Mobile.InternalStorage.Formatter;
            PickedUser = null;
            SearchText = "";
            StartWithDate = new DateTime();
            EndWithDate = new DateTime();

            Mobile.InternalStorage.SmsAdded += ReceiveMessagesFromDb;
            FormatChanged += ShowMessages;
            FilterChanged += ShowMessages;
            RunMessageGenerator += MessageGenerator.RunMessageGenerator;
        }

        public Mobile Mobile { get; }
        public FormatDelegate Formatter { get; set; }
        private IEnumerable<Message> SelectedMessages { get; set; }
        private string SearchText { get; set; }
        public MessageGeneratorBasic MessageGenerator { get; set; }

        public string PickedUser { get; set; }

        public DateTime StartWithDate { get; set; }

        public DateTime EndWithDate { get; set; }

        public bool JoinFilteringCheck { get; set; }

        public event FormatChangedDelegate FormatChanged;
        public event FilterChangedDelegate FilterChanged;
        public event RunMessageGeneratorDelegate RunMessageGenerator;

        private void InitializeComboBoxes()
        {
            formatComboBox.Items.Add(Formats.None);
            formatComboBox.Items.Add(Formats.FormatStartWithDate);
            formatComboBox.Items.Add(Formats.FormatEndWithDate);
            formatComboBox.Items.Add(Formats.FormatUpperCase);
            formatComboBox.Items.Add(Formats.FormatLowerCase);
            formatComboBox.Items.Add(Formats.Custom);
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
                    Mobile.InternalStorage.FilterByUnion(messages, PickedUser, SearchText, StartWithDate, EndWithDate);

            foreach (var message in SelectedMessages)
            {
                var formatMessage = Mobile.InternalStorage.FormatText(message);
                MessageListView.Items.Add(new ListViewItem(new[] {formatMessage.User, formatMessage.FormatText}));
            }
        }

        private void SmsViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageGenerator.MessageGeneratorOnSwitch = false;
        }

        private void SmsViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageGenerator.MessageGeneratorOnSwitch = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageGenerator.MessageGeneratorOnSwitch)
            {
                MessageGenerator.MessageGeneratorOnSwitch = false;
            }
            else
            {
                MessageGenerator.MessageGeneratorOnSwitch = true;
                var handler = RunMessageGenerator;
                handler?.Invoke();
            }
        }
    }
}