namespace KSBL_csharpprep_Lab1
{
    public class ExternalStorage : Storage
    {
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
            return "External Storage";
        }
    }
}