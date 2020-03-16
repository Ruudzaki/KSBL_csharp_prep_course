namespace KSBL_Class_Library.Components.Storage
{
    public class InternalStorage : Storage
    {
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
            return "Internal Storage";
        }
    }
}