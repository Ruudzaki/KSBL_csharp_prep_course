using System;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;

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
            string message = "Hello! This is a KSBL's dummy incoming message.";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmsViewer(mobile, output, message));
        }
    }
}