namespace KSBL_csharpprep_Lab1
{
    public interface ILoadFromHardMemory
    {
    }

    public interface ILoadToHardMemory
    {
    }

    public abstract class BasicHardMemory
    {
        public int Size { get; set; }

        public abstract void LoadFromHardMemory(ILoadFromHardMemory loadFromHardMemory);
        public abstract void LoadToHardMemory(ILoadToHardMemory loadToHardMemory);
    }

    internal class InternalHardMemory : BasicHardMemory
    {
        public override void LoadFromHardMemory(ILoadFromHardMemory loadFromHardMemory)
        {
            //here logic for load from internal hard memory
        }

        public override void LoadToHardMemory(ILoadToHardMemory loadToHardMemory)
        {
            //here logic for load to internal hard memory
        }

        public override string ToString()
        {
            return "Internal Hard Memory";
        }
    }

    internal class ExternalHardMemory : BasicHardMemory
    {
        public override void LoadFromHardMemory(ILoadFromHardMemory loadFromHardMemory)
        {
            //here logic for load from external hard memory
        }

        public override void LoadToHardMemory(ILoadToHardMemory loadToHardMemory)
        {
            //here logic for load to external hard memory
        }

        public override string ToString()
        {
            return "External Hard Memory";
        }
    }
}