namespace KSBL_Class_Library.Components.RAM
{
    public interface ILoadToRam
    {
        int Address { get; set; }
        int Value { get; set; }
    }
}