namespace KSBL_csharpprep_Lab1.Components.Storage
{
    public class ExternalStorage : BasicStorage
    {
        public ExternalStorage(int capacity) : base(capacity)
        {
        }

        public override void LoadFromHardMemory(LoadFromStorage loadFromHardMemory)
        {
            //here logic for load from external hard memory
        }

        public override void LoadToHardMemory(ILoadToStorage loadToHardMemory)
        {
            //here logic for load to external hard memory
        }

        public override string ToString()
        {
            return "External BasicStorage";
        }
    }
}