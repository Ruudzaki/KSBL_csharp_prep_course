namespace KSBL_csharpprep_Lab1
{
    public class RAM : BasicRAM
    {
        public RAM(int size) : base(size)
        {
        }

        public override void LoadFromRAM(ILoadFromRAM loadFromRam)
        {
            //here logic for Load from RAM process 
        }

        public override void LoadToRAM(ILoadToRAM loadFromRam)
        {
            //here logic for Load to RAM process
        }

        public override string ToString()
        {
            return "RAM";
        }
    }
}