namespace KSBL_Class_Library.Components.TouchScreen
{
    public abstract class BasicTouch
    {
        protected BasicTouch(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public abstract void Touch(IScreenTouch screenTouch);
    }
}