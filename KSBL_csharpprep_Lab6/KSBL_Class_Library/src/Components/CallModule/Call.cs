using System;

namespace KSBL_Class_Library.Components.CallModule
{
    public class Call : IComparable, ICloneable
    {
        public Call(Contact contact, CallType callType)
        {
            Contact = contact;
            CallType = callType;
            CallTime = DateTime.Now;
        }

        public CallType CallType { get; }
        public DateTime CallTime { get; set; }
        public Contact Contact { get; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            var call = (Call) obj;
            return call != null && call.Contact.Equals(Contact) && call.CallType.Equals(CallType);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) CallType * 397) ^ (Contact != null ? Contact.GetHashCode() : 0);
            }
        }
    }
}