using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.ISP4
{
    public interface IMessage
    {
        bool Send(IList<string> toAddress, string messageBody);
    }

    public interface IEmailMessage : IMessage
    {
        string Subject { get; set; }
        IList<string> BccAddresses { get; set; }
    }

    public class SmtpMessage : IEmailMessage
    {
        public IList<string> BccAddresses { get; set; }
        public string Subject { get; set; }
        public bool Send(IList<string> toAddress, string messageBody)
        {
            // Code for sending E-mail.
            return true;
        }
    }

    /// <summary>
    /// SmsMessage needs only toAddress and messageBody, so now we can utilise IMessage interface to avoid unnecessary implementation.
    /// </summary>
    public class SmsMessage : IMessage
    {
        public bool Send(IList<string> toAddress, string messageBody)
        {
            // Code for sending SMS.
            return true;
        }
    }
}
