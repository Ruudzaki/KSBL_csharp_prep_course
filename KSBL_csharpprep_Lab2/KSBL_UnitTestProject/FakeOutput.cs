using KSBL_Class_Library.Components.Speaker;

namespace KSBL_UnitTestProject
{
    public class FakeOutput : IOutput
    {
        public string Write(string text)
        {
            return "Test sound is playing";
        }

        public string WriteLine(string text)
        {
            return "Test sound is playing";
        }
    }
}
