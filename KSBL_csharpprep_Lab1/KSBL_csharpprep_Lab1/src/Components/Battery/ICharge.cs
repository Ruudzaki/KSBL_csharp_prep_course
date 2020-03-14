namespace KSBL_csharpprep_Lab1.Components.Battery
{
    public interface ICharge
    {
        string ChargerType { get; set; }
        string Voltage { get; set; }
    }
}