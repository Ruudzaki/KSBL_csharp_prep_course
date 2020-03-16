namespace KSBL_Class_Library.Components.Storage
{
    public class ExternalStorage : Storage
    {
        public override void LoadFromHardMemory(ILoadFromStorage loadFromHardMemory)
        {
            //here logic for load from external hard memory
        }

        public override void LoadToHardMemory(ILoadToStorage loadToHardMemory)
        {
            //here logic for load to external hard memory
        }

        public override string ToString()
        {
            return "External Storage";
        }
    }
}