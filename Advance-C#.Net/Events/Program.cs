using System;
using System.Threading;

namespace Events
{
    public class Video
    {
        public string Title { get; set; }
    }

    public class VideoEventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // EventHandler // if EventArgs is empty
        // EventHandler<Arg> // if EventArgs is not empty
        // public event VideoEncodedEventHandler VideoEncoded;

        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode()
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            VideoEncoded(this, new VideoEventArgs());
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mail Service notify");
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service notify");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var messageService = new MessageService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            

            videoEncoder.Encode();
        }
    }
}
