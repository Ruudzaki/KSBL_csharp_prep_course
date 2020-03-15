namespace KSBL_Class_Library
{


    public abstract class BasicRAM
    {
        public int Size { get; set; }

        public abstract void LoadFromRAM(ILoadFromRAM loadFromRam);
        public abstract void LoadToRAM(ILoadToRAM loadFromRam);
    }

   
}