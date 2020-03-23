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

        public Mobile Mobile { get; }

        public SmsViewer(Mobile mobile, IOutput output, string message)
        {
            InitializeComponent();
            InitializeComboBox();

            Mobile = mobile;
            Mobile.Output = output;
            MaximizeBox = false;

            MessageGenerator(message, 0, 1000);
        }

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
            if (comboBox1.SelectedIndex == 0) Mobile.SmsProvider.Formatter = FormatNone;
            if (comboBox1.SelectedIndex == 1) Mobile.SmsProvider.Formatter = FormatStartWithDate;
            if (comboBox1.SelectedIndex == 2) Mobile.SmsProvider.Formatter = FormatEndWithDate;
            if (comboBox1.SelectedIndex == 3) Mobile.SmsProvider.Formatter = FormatUpperCase;
            if (comboBox1.SelectedIndex == 4) Mobile.SmsProvider.Formatter = FormatLowerCase;
            if (comboBox1.SelectedIndex == 5) Mobile.SmsProvider.Formatter = FormatUpperStartWithDate;
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