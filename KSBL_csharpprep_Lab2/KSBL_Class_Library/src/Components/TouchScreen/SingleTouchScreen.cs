namespace KSBL_csharpprep_Lab1.Components.TouchScreen
{
    public class SingleTouchScreen : BasicTouch
    {
        public SingleTouchScreen(string name) : base(name)
        {
        }

        public override void Touch(IScreenTouch screenTouch)
        {
            //here logic of touch can be added 
        }

        public override string ToString()
        {
            {
                return "Single Touch";
            }
        }
    }
}