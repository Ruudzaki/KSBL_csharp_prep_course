using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KSBL_CallWinForm.CallGeneratorFactory;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm
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

            AddInitialContacts(mobile);

            CallGeneratorCreator callGeneratorCreator1 = new CallGeneratorCreatorTask();
            CallGeneratorCreator callGeneratorCreator2 = new CallGeneratorCreatorThread();

            var callGenerator = callGeneratorCreator1.Create(mobile);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CallViewer(mobile, callGenerator));
        }

        private static void AddInitialContacts(Mobile mobile)
        {
            mobile.InternalStorage.AddContact("HAOK", new List<string> {"111"});
            mobile.InternalStorage.AddContact("SAI", new List<string> {"222"});
            mobile.InternalStorage.AddContact("KSBL", new List<string> {"333", "555"});
        }
    }
}