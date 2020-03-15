namespace KSBL_Class_Library
{
    public abstract class Storage
    {
        public int Size { get; set; }

        public abstract void LoadFromHardMemory(LoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);
    }
}