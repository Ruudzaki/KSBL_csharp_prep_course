using KSBL_Class_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSBL_Class_Library.Components.SmsModule;
using KSBL_Class_Library.Mobile;
using Timer = System.Windows.Forms.Timer;



namespace KSBL_SmsWinForms_app
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Mobile mobile = new SimCorpMobile();
            IOutput output = new WinFormOutput();

            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SMSViewer(mobile, output));


        }

        private static void SmsProvider_SmsRecieved(string message)
        {
            Console.WriteLine(message);
        }
    }
}
