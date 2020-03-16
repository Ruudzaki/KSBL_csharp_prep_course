namespace KSBL_csharpprep_Lab1.Components.Storage
{
    public abstract class BasicStorage
    {
        protected BasicStorage(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; }

        public abstract void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);
    }
}