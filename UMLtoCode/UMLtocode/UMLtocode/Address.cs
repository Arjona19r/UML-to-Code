using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtocode
{
    internal struct Address
    {
        public string street;
        public string city;
        public string state;
        public int PostalCode;
        public string Country;
        public Person Person;

        public bool Validate()
        {
            return true;
        }
    }
}
