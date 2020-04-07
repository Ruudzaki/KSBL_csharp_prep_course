namespace KSBL_Class_Library.Components.Battery
{
    public interface ICharge
    {
        int Voltage { get; }

        string Charge(object data);
    }
}