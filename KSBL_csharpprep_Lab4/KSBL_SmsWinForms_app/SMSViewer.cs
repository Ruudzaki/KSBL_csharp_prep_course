using System;
using System.Threading;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Message = KSBL_Class_Library.Components.SmsModule.Message;
using Timer = System.Threading.Timer;

namespace KSBL_SmsWinForms_app
{
    public partial class SmsViewer : Form
    {
        public SmsViewer(Mobile mobile, IOutput output, Message message1, Message message2, Message message3)
        {
            InitializeComponent();
            InitializeComboBox();

            Mobile = mobile;
            Mobile.Output = output;
            MaximizeBox = false;

            MessageGenerator(message1, 0, 1000);
            MessageGenerator(message2, 0, 2000);
            MessageGenerator(message3, 0, 3000);
            Mobile.SmsProvider.SmsReceived += SmsProvider_SmsReceived;
        }

        public Mobile Mobile { get; }

        private void InitializeComboBox()
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
            TimerCallback tm = Mobile.SmsProvider.PrintMessage;
            var unused = new Timer(tm, message, dueTime, period);
        }

        private void SmsProvider_SmsReceived(object message)
        {
            if (InvokeRequired) Invoke(new SmsProvider.SmsRecievedDelegate(OnSmsReceived), message);
        }

        private void OnSmsReceived(Message message)
        {
            richTextBox1.AppendText($"{message.FormatText} {Environment.NewLine}");
        }

        private void formatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (formatComboBox.SelectedIndex)
            {
                case 0:
                    Mobile.SmsProvider.Formatter = FormatNone;
                    break;
                case 1:
                    Mobile.SmsProvider.Formatter = FormatStartWithDate;
                    break;
                case 2:
                    Mobile.SmsProvider.Formatter = FormatEndWithDate;
                    break;
                case 3:
                    Mobile.SmsProvider.Formatter = FormatUpperCase;
                    break;
                case 4:
                    Mobile.SmsProvider.Formatter = FormatLowerCase;
                    break;
                case 5:
                    Mobile.SmsProvider.Formatter = FormatUpperStartWithDate;
                    break;
            }
        }


        //Format Methods to delegate
        public static Message FormatNone(Message message)
        {
            message.FormatText = $"{message.Text} #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatStartWithDate(Message message)
        {
            message.FormatText = $"[{message.ReceivingTime}] {message.Text} #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatEndWithDate(Message message)
        {
            message.FormatText = $"{message.Text} [{message.ReceivingTime}] #{message.ReferenceNumber}";
            return message;
        }

        public static Message FormatUpperCase(Message message)
        {
            message.FormatText = message.Text.ToUpper() + " #" + message.ReferenceNumber;
            return message;
        }

        public static Message FormatLowerCase(Message message)
        {
            message.FormatText = message.Text.ToLower() + " #" + message.ReferenceNumber;
            return message;
        }

        public static Message FormatUpperStartWithDate(Message message)
        {
            message.FormatText = $"[{message.ReceivingTime}] {message.Text.ToUpper()} #{message.ReferenceNumber}";
            return message;
        }
    }
}