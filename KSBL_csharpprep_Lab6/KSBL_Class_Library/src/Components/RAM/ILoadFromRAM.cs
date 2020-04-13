namespace KSBL_Class_Library.Components.RAM
{
    public interface ILoadFromRam
    {
        int Address { get; set; }
        int Value { get; set; }
    }
}