using KSBL_Class_Library;

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