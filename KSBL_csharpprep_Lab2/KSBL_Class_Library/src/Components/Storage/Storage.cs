namespace KSBL_Class_Library.Components.Storage
{
    public abstract class Storage
    {
        public int Size { get; set; }

        public abstract void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);
    }
}