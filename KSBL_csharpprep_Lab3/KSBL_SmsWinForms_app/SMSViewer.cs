using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Timer = System.Threading.Timer;

namespace KSBL_SmsWinForms_app
{
    public partial class SMSViewer : Form
    {
        public SMSViewer(Mobile mobile, IOutput output)
        {
            InitializeComponent();
            Mobile = mobile;
            Mobile.Output = output;
            string message = "Hello!";


            comboBox1.Items.Add("FormatStartWithDate");
            comboBox1.Items.Add("FormatEndWithDate");
            comboBox1.Items.Add("FormatUpperCase");
            comboBox1.Items.Add("FormatLowerCase");
            comboBox1.Items.Add("FormatUpperStartWithDate");

            Mobile.SmsProvider.SmsReceived += new SmsProvider.SmsRecievedDelegate(SmsProvider_SmsRecieved);

            TimerCallback tm = mobile.SmsProvider.PrintMessage;

            var timer = new Timer(tm, message, 0, 1000);
            
        }

        private void SmsProvider_SmsRecieved(object message)
        {
            if (InvokeRequired)
            {
                Invoke(new SmsProvider.SmsRecievedDelegate(OnSmsRecieved), message);
            }

        }

        private void OnSmsRecieved(string message)
        {
            richTextBox1.AppendText($"{message} {Environment.NewLine}");
        }

        public Mobile Mobile { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Mobile.SmsProvider.Formatter = new SmsProvider.FormatDelegate(FormatStartWithDate);
            }

            if (comboBox1.SelectedIndex == 1)
            {
                Mobile.SmsProvider.Formatter = new SmsProvider.FormatDelegate(FormatEndWithDate);
            }

            if (comboBox1.SelectedIndex == 2)
            {
                Mobile.SmsProvider.Formatter = new SmsProvider.FormatDelegate(FormatUpperCase);
            }

            if (comboBox1.SelectedIndex == 3)
            {
                Mobile.SmsProvider.Formatter = new SmsProvider.FormatDelegate(FormatLowerCase);
            }
            if (comboBox1.SelectedIndex == 4)
            {
                Mobile.SmsProvider.Formatter = new SmsProvider.FormatDelegate(FormatUpperStartWithDate);
            }
        }

        private static string FormatStartWithDate(string message)
        {
            return $"[{DateTime.Now}] {message}";
        }

        private static string FormatEndWithDate(string message)
        {
            return $"{message} [{DateTime.Now}]";
        }

        private static string FormatUpperCase(string message)
        {
            return message.ToUpper();
        }

        private static string FormatLowerCase(string message)
        {
            return message.ToLower();
        }

        private static string FormatUpperStartWithDate(string message)
        {
            return $"[{DateTime.Now}] {message.ToUpper()}";
        }
    }
}
