namespace KSBL_csharpprep_Lab1.Components.RAM
{
    public abstract class BasicRAM
    {
        protected BasicRAM(int size)
        {
            Size = size;
        }

        public int Size { get; }

        public abstract void LoadFromRAM(ILoadFromRAM loadFromRam);
        public abstract void LoadToRAM(ILoadToRAM loadFromRam);
    }
}