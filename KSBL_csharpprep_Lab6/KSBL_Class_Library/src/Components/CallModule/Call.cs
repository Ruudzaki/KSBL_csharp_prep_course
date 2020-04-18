using System;
using KSBL_Class_Library.Components.Storage;

namespace KSBL_Class_Library.Components.CallModule
{
    public class Call : IComparable, ICloneable
    {
        public string PhoneNumber { get; set; }
        public CallType CallType { get; set; }
        public DateTime CallTime { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public Call(string phoneNumber, CallType callType)
        {
            PhoneNumber = phoneNumber;
            CallType = callType;
            CallTime = DateTime.Now;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
