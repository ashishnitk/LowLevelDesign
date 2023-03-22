using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.SRP
{
    /// <summary>
    //  Please implement a new Property AccountHolderName.
    //  Some new rule has been incorporated to calculate interest.
    /// </summary>
    public class BankAccount
    {
        public BankAccount() { }

        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }

        public decimal CalculateInterest()
        {
            // Code to calculate Interest
            return 0;
        }

    }
}
