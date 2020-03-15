namespace KSBL_Class_Library
{
    public class InternalStorage : Storage
    {
        public override void LoadFromHardMemory(LoadFromStorage loadFromHardMemory)
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