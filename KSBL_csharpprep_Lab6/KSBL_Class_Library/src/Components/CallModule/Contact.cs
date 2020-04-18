using System.Collections.Generic;

namespace KSBL_Class_Library.Components.CallModule
{
    public class Contact
    {
        public string Name { get; set; }
        public List<string> PhoneNumbers { get; set; }

        public Contact(string name, List<string> phoneNumbers)
        {
            Name = name;
            PhoneNumbers = phoneNumbers;
        }
    }
}
