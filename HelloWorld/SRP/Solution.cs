using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.SRP1
{
    public interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal AccountBalance { get; set; }
    }

    public interface IInterstCalculator
    {
        decimal CalculateInterest();
    }

    public class BankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }

    public class InterstCalculator : IInterstCalculator
    {
        // public decimal CalculateInterest(IBankAccount account)
        public decimal CalculateInterest()
        {
            // Write your logic here
            return 1000;
        }
    }
}
