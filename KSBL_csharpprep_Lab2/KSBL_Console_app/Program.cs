using System;
using KSBL_Class_Library.Mobile;

namespace KSBL_csharpprep_Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Mobile mobile = new SimCorpMobile();

            Console.WriteLine(mobile);

            mobile.SelectPlaybackComponent();
            mobile.Play(new object());

            Console.ReadKey();
        }
    }
}