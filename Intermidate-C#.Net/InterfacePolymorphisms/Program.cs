using System;

namespace InterfacePolymorphisms
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            videoEncoder.RegisterNotificationMethods(new SmsNotification(), new MailNotification());

            videoEncoder.Encode(new Video());
        }
    }
}
