using System;
using System.Collections.Generic;
using System.Text;

namespace UMLtocode
{
    internal struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
        public Account account;
    }
}
