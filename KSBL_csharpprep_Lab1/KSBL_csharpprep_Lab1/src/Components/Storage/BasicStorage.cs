namespace KSBL_csharpprep_Lab1
{
    public abstract class BasicStorage
    {
        protected BasicStorage(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }

        public abstract void LoadFromHardMemory(LoadFromStorage loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToStorage loadToHardMemory);
    }
}