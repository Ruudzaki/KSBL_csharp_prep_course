namespace KSBL_Class_Library.Components.Battery
{
    public interface ICharge
    {
        string ChargerType { get; set; }
        string Voltage { get; set; }
    }
}