using System;
using System.Collections.Generic;

namespace InterfacePolymorphisms
{
    public class VideoEncoder
    {
        private readonly List<INotification> _notifications;

        public VideoEncoder()
        {
            _notifications = new List<INotification>();
        }

        public void RegisterNotificationMethods(params INotification[] notifications)
        {
            _notifications.AddRange(notifications);
        }
        public void Encode(Video video)
        {
            Console.WriteLine("Encode video");

            foreach (var channel in _notifications)
            {
                channel.Send();
            }
        }
    }
}