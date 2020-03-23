using System;
using System.Threading;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Timer = System.Threading.Timer;

namespace KSBL_SmsWinForms_app
{
    public partial class SmsViewer : Form
    {
        public SmsViewer(Mobile mobile, IOutput output, string message)
        {
            InitializeComponent();
            InitializeComboBox();

            Mobile = mobile;
            Mobile.Output = output;
            MaximizeBox = false;

            MessageGenerator(message, 0, 1000);
        }

        public Mobile Mobile { get; }

        private void InitializeComboBox()
        {
            comboBox1.Items.Add(Formats.None);
            comboBox1.Items.Add(Formats.FormatStartWithDate);
            comboBox1.Items.Add(Formats.FormatEndWithDate);
            comboBox1.Items.Add(Formats.FormatUpperCase);
            comboBox1.Items.Add(Formats.FormatLowerCase);
            comboBox1.Items.Add(Formats.Custom);
        }

        public void MessageGenerator(string message, int dueTime, int period)
        {
            Mobile.SmsProvider.SmsReceived += SmsProvider_SmsReceived;

            TimerCallback tm = Mobile.SmsProvider.PrintMessage;
            var unused = new Timer(tm, message, dueTime, period);
        }

        private void SmsProvider_SmsReceived(object message)
        {
            if (InvokeRequired) Invoke(new SmsProvider.SmsRecievedDelegate(OnSmsReceived), message);
        }

        private void OnSmsReceived(string message)
        {
            richTextBox1.AppendText($"{message} {Environment.NewLine}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
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
        public static string FormatNone(string message)
        {
            return message;
        }

        public static string FormatStartWithDate(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        public static string FormatEndWithDate(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }

        public static string FormatUpperCase(string message)
        {
            return message.ToUpper();
        }

        public static string FormatLowerCase(string message)
        {
            return message.ToLower();
        }

        public static string FormatUpperStartWithDate(string message)
        {
            return $"[{DateTime.Now}] {message.ToUpper()}";
        }
    }
}