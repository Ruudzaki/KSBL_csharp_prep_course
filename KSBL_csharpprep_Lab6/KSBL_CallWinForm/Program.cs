using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KSBL_CallWinForm.CallGeneratorFactory;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;

namespace KSBL_CallWinForm
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

            CallGeneratorCreator callGeneratorCreator1 = new CallGeneratorCreatorTask();
            CallGeneratorCreator callGeneratorCreator2 = new CallGeneratorCreatorThread();

            var callGenerator = callGeneratorCreator1.Create(mobile);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CallViewer(mobile, output, callGenerator));
        }
    }
}
