using System;

namespace InterfacePolymorphisms
{
    public class SmsNotification:INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}