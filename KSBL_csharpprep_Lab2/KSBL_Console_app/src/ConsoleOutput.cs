using System;
using KSBL_Class_Library.Components.Speaker;

namespace KSBL_Console_app
{
    public class ConsoleOutput : IOutput
    {
        public string Write(string text)
        {
            Console.Write(text);
            return text;
        }

        public string WriteLine(string text)
        {
            Console.WriteLine(text);
            return text;
        }
    }
}