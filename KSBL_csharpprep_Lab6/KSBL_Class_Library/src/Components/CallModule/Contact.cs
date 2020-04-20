using System;
using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CallModule
{
    public class Contact : IComparable
    {
        public Contact(string name, List<string> phoneNumbers)
        {
            Name = name;
            PhoneNumbers = phoneNumbers;
        }

        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object o)
        {
            var contact = (Contact) o;
            return contact != null && Name == contact.Name;
        }


        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (PhoneNumbers != null ? PhoneNumbers.GetHashCode() : 0);
            }
        }
    }
}