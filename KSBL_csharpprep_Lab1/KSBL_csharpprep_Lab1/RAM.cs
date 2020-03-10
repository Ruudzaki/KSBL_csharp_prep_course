namespace KSBL_csharpprep_Lab1
{
    public interface ILoadFromRAM
    {
    }

    public interface ILoadToRAM
    {
    }

    public abstract class BasicRAM
    {
        public int Size { get; set; }

        public abstract void LoadFromRAM(ILoadFromRAM loadFromRam);
        public abstract void LoadToRAM(ILoadToRAM loadFromRam);
    }

    public class RAM : BasicRAM
    {
        public override void LoadFromRAM(ILoadFromRAM loadFromRam)
        {
            //here logic for Load from RAM process 
        }

        public override void LoadToRAM(ILoadToRAM loadFromRam)
        {
            //here logic for Load to RAM process
        }

        public override string ToString()
        {
            return "RAM";
        }
    }
}