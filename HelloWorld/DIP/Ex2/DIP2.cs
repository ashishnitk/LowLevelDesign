using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.DIP.Ex2
{
    public class Email
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendEmail()
        {
            //Send email
        }
    }

    public class SMS
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendSMS()
        {
            //Send sms
        }
    }

    /// <summary>
    /// High Level
    /// </summary>
    public class Notification
    {
        private Email _email;
        private SMS _sms;

        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
