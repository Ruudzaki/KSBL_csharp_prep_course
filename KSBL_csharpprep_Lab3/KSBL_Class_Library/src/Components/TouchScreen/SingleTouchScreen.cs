﻿namespace KSBL_Class_Library.Components.TouchScreen
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