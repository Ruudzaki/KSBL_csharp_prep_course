using System;
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

            Mobile.SmsProvider.SmsReceived += new SmsProvider.SmsRecievedDelegate(SmsProvider_SmsRecieved);

            TimerCallback tm = mobile.SmsProvider.PrintMessage;

            var timer = new Timer(tm, message, 0, 2000);
            
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
    }
}
