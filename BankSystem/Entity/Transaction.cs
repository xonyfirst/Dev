using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem.Entity
{
    public class Transaction
    {
        public string IBAN {get; set; }
        public string TYPE { get; set; }
        public string TOTAL { get; set; }
    }
}
