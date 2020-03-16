using System.Collections.Generic;

namespace KSBL_Class_Library.Components.TouchScreen
{
    public class MultiTouchScreen : BasicTouch
    {
        public MultiTouchScreen(int maxTouchInput)
        {
            MaxTouchInputs = maxTouchInput;
        }

        public int MaxTouchInputs { get; set; }

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