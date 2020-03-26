namespace KSBL_Class_Library.Components.Storage
{
    public class InternalStorage : BasicStorage
    {
        public InternalStorage(int capacity) : base(capacity)
        {
        }

        public override void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory)
        {
            //here logic for load from internal hard memory
        }

        public override void LoadToHardMemory(ILoadToStorage loadToHardMemory)
        {
            //here logic for load to internal hard memory
        }

        public override string ToString()
        {
            return "Internal BasicStorage";
        }
    }
}