using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtocode
{
    internal class Account
    {
        public string IBAN;
        protected float Amount;
        public Customer cust;
        public Person person;

        public bool Transaction(string param)
        {
            return true;
        }
    }
}
