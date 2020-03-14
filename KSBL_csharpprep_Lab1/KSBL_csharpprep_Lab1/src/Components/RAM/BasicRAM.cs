namespace KSBL_csharpprep_Lab1.Components.RAM
{
    public abstract class BasicRam
    {
        protected BasicRam(int size)
        {
            Size = size;
        }

        public int Size { get; }

        public abstract void LoadFromRam(ILoadFromRam loadFromRam);
        public abstract void LoadToRam(ILoadToRam loadFromRam);
    }
}