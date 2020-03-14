using System;
using KSBL_csharpprep_Lab1.Mobile;

namespace KSBL_csharpprep_Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Mobile.Mobile mobile = new SimCorpMobile();

            Console.WriteLine(mobile);

            Console.ReadKey();
        }
    }
}