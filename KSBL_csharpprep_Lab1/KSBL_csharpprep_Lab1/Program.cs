using System;

namespace KSBL_csharpprep_Lab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Mobile mobile = new SimCorpMobile();

            Console.WriteLine(mobile.GetDescription());

            Console.ReadKey();
        }
    }
}