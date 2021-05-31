using System;

namespace InterfacePolymorphisms
{
    public class MailNotification :INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Mail...");
        }
    }
}