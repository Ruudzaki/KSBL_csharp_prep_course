using System;
using KSBL_Class_Library.Mobile;

namespace KSBL_Console_app
{
    internal class Program
    {
        private static void Main()
        {
            Mobile mobile = new SimCorpMobile();
            mobile.Output = new ConsoleOutput();

            mobile.Output.WriteLine(mobile.ToString());

            mobile.SelectPlaybackComponentConsole();
            mobile.Play(new object());

            Console.ReadKey();
        }
    }
}