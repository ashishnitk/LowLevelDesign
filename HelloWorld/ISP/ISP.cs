using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// In the SmsMessage we don’t require BccAddresses and Subject, 
/// but we are forced to implement it because of IMessage interface. 
/// So it violates the ISP principle.
/// </summary>
namespace HelloWorld.ISP
{
    public interface IMessage
    {
        IList<string> ToAddress { get; set; }
        IList<string> BccAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }
        bool Send();
    }

    public class SmtpMessage : IMessage
    {
        public IList<string> ToAddress { get; set; }
        public IList<string> BccAddresses { get; set; }
        public string MessageBody { get; set; }
        public string Subject { get; set; }
        public bool Send()
        {
            return true;
            // Code for sending E-mail.
        }
    }

    public class SmsMessage : IMessage
    {
        public IList<string> ToAddress { get; set; }
        public IList<string> BccAddresses
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public string MessageBody { get; set; }
        public string Subject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public bool Send()
        {
            // Code for sending SMS.
            return true;
        }
    }
}
