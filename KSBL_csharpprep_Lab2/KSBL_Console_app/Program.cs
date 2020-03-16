using System;
using KSBL_Class_Library.Mobile;

namespace KSBL_Console_app
{
    internal class Program
    {
        private static void Main()
        {
            Mobile mobile = new SimCorpMobile();

            Console.WriteLine(mobile);

            mobile.SelectPlaybackComponent();
            mobile.Play(new object());

            Console.ReadKey();
        }
    }
}