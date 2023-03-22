
using System;

namespace RealWorld134s
{
    class Bank
    {
        internal bool HasSufficientSavings(Customer cust, int amount)
        {
            Console.WriteLine(cust.Name + " has has suff balance");
            return true;
        }
    }

    class Loan
    {
        internal bool HasBadLoan(Customer cust)
        {
            Console.WriteLine(cust.Name + " has no bad loan");
            return true;
        }
    }

    class Credit
    {
        internal bool HasGoodCredit(Customer cust)
        {
            Console.WriteLine(cust.Name + " has good credit");
            return true;
        }
    }


    class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        internal bool IsEligible(Customer cust, int amount)
        {
            bool eligible = true;
            if (!bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!loan.HasBadLoan(cust))
            {
                eligible = false;

            }
            else if (!credit.HasGoodCredit(cust))
            {
                eligible = false;

            }
            return eligible;

        }
    }

    class Customer
    {
        private string name;
        public Customer(string n)
        {
            name = n;
        }

        public string Name
        {
            get { return name; }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Mortgage mortagage = new Mortgage(); // Credit, Bank, Loan
    //        Customer c1 = new Customer("Tushar");
    //        bool eligible = mortagage.IsEligible(c1, 125000);


    //        Customer c2 = new Customer("Kapil");
    //        bool eligible = mortagage.IsEligible(c2, 125000);

    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
