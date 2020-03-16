using KSBL_Class_Library.Components.Speaker;

namespace KSBL_Class_Library
{
    public class WinFormOutput : IOutput
    {
        public string Text { get; set; }

        public string Write(string text)
        {
            return text;
        }

        public string WriteLine(string text)
        {
            return text;
        }
    }
}