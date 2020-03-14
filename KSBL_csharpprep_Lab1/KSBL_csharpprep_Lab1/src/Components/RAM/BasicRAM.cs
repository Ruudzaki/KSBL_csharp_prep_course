namespace KSBL_csharpprep_Lab1
{


    public abstract class BasicRAM
    {
        public int Size { get; set; }

        public abstract void LoadFromRAM(ILoadFromRAM loadFromRam);
        public abstract void LoadToRAM(ILoadToRAM loadFromRam);
    }

   
}