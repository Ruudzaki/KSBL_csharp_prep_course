using System;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;
using Message = KSBL_Class_Library.Components.SmsModule.Message;

namespace KSBL_SmsWinForms_app
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Mobile mobile = new SimCorpMobile();
            IOutput output = new WinFormOutput();

            var message1 = new Message("KSBL", "Hello! This is a KSBL's dummy incoming message.", DateTime.Now);
            var message2 = new Message("VZL", "Hello! This is a VZL's dummy incoming message.", DateTime.Now);
            var message3 = new Message("OKTK", "Hello! This is a OKTK's dummy incoming message.", DateTime.Now);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmsViewer(mobile, output, message1, message2, message3));
        }
    }
}