using KSBL_Class_Library;
using KSBL_Class_Library.Components.Speaker;

namespace KSBL_UnitTestProject
{
    public class FakeOutput : IOutput
    {
        public string Write(string text)
        {
            return "Test Output is running";
        }

        public string WriteLine(string text)
        {
            return "Test Output is running";
        }
    }
}
