using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1.Components.TouchScreen
{
    public class MultiTouchScreen : BasicTouch
    {
        public MultiTouchScreen(string name, int maxTouchInput) : base(name)
        {
            MaxTouchInputs = maxTouchInput;
        }

        public int MaxTouchInputs { get; }

        public override void Touch(IScreenTouch screenTouch)
        {
            //here logic of touch can be added 
        }

        public void Touch(List<IScreenTouch> screenTouches)
        {
            //here logic of several touch can be added
        }

        public override string ToString()
        {
            {
                return $"Multi Touch ({MaxTouchInputs} touches supported simultaneously)";
            }
        }
    }
}