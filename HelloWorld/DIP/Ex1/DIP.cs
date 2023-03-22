using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.DIP
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBorth { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class Contact
    {
        public string Email { get; set; }
        public string Fax { get; set; }
    }

    /// <summary>
    /// LowLevel
    /// </summary>
    public class Notification
    {
        public Notification()
        {
        }
        public bool SendNotification(Customer customer)
        {
            return Send(customer.Address);
        }
        private bool Send(Address address)
        {
            //Letter Print Logic 
            return true;
        }
    }

    /// <summary>
    /// HighLevel
    /// </summary>
    public class Account
    {
        public void OpenAccount()
        {
            Customer customer = new Customer()
            {
                FirstName = "Ashish",
                LastName = "Prasad",
                DateOfBorth = new DateTime(1981, 07, 05),
                Address = new Address
                {
                    Address1 = "SVF",
                    Address2 = "Hello",
                    City = "bangalore",
                    State = "KA",
                    Zip = "201002"
                },
                Contact = new Contact
                {
                    Email = "ashish.prasad@yahoo.com",
                    Fax = "3234234242"
                }
            };
            //concrete  Object 
            Notification notification = new Notification();
            notification.SendNotification(customer);
        }
    }
}
