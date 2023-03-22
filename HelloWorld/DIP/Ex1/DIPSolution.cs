using HelloWorld.DIP;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.DIP1
{
    public interface INotificationSender
    {
        bool SendNotification(Customer customer);
    }

    public class Account
    {
        INotificationSender emailSender = null;
        public Account(INotificationSender sender)
        {
            //object is passed through constructor
            emailSender = sender;
        }
        public void OpenAccount()
        {
            Customer customer = new Customer()
            {
                FirstName = "Dhanik",
                LastName = "Sahni",
                DateOfBorth = new DateTime(1981, 07, 05),
                Address = new Address
                {
                    Address1 = "SVF",
                    Address2 = "rakshapuram Kuan",
                    City = "bangalore",
                    State = "UP",
                    Zip = "201002"
                },
                Contact = new Contact
                {
                    Email = "ashish.prasad@yahoo.com",
                    Fax = "3234234242"
                }
            };
            //abstract Object 
            emailSender.SendNotification(customer);
        }
    }












    public class EmailNotification : INotificationSender
    {
        public bool SendNotification(Customer customer)
        {
            return Send(customer.Contact);
        }
        private bool Send(Contact contact)
        {
            //Send Email Logic
            return true;
        }
    }

    public class LetterNotification : INotificationSender
    {
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






}
