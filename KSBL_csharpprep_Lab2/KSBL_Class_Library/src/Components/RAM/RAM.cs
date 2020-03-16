namespace KSBL_Class_Library.Components.RAM
{
    public class Ram : BasicRam
    {
        public override void LoadFromRam(ILoadFromRam loadFromRam)
        {
            //here logic for Load from RAM process 
        }

        public override void LoadToRam(ILoadToRam loadFromRam)
        {
            //here logic for Load to RAM process
        }

        public override string ToString()
        {
            return "RAM";
        }
    }
}