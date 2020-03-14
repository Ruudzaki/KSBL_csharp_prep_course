using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
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
                return string.Format("Multi Touch ({0} touches supported simultaneously)", MaxTouchInputs);
            }
        }
    }

}