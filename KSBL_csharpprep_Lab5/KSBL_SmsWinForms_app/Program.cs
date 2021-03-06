﻿using System;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;
using KSBL_SmsWinForms_app.MessageGeneratorFactory;

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

            MessageGeneratorCreator messageGeneratorCreator1 = new MessageGeneratorCreatorTask();
            MessageGeneratorCreator messageGeneratorCreator2 = new MessageGeneratorCreatorThread();

            var messageGenerator = messageGeneratorCreator1.Create(mobile);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SmsViewer(mobile, output, messageGenerator));
        }
    }
}