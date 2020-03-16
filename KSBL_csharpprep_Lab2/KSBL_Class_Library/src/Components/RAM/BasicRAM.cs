namespace KSBL_Class_Library.Components.RAM
{
    public abstract class BasicRam
    {
        public int Size { get; set; }

        public abstract void LoadFromRam(ILoadFromRam loadFromRam);
        public abstract void LoadToRam(ILoadToRam loadFromRam);
    }
}