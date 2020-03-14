using System.Collections.Generic;

namespace KSBL_csharpprep_Lab1
{

    public class SingleTouchScreen : BasicTouch
    {
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