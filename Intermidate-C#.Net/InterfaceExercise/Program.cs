using System;

namespace WorkflowEngine
{
    public interface IActivity
    {
        void Execute();
    }

    public class VideoUploading : IActivity
    {
        public void Execute()
        {
            Uploading();
            CallThirdParty();
            SendEmail();
            ChangeStatusDB();
        }

        private void Uploading()
        {
            Console.WriteLine("Upload a video to a cloud storage.");
        }

        private void CallThirdParty()
        {
            Console.WriteLine("Call a web service provided by a third-party video encoding service to tell them you have video ready for encoding.");
        }

        private void SendEmail()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them that the video started processing.");
        }

        private void ChangeStatusDB()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”.");
        }
    }
    public class WorkflowEngine
    {
        private readonly IActivity _activity;

        public WorkflowEngine(IActivity activity)
        {
            _activity = activity;
        }

        public void Run()
        {
            _activity.Execute();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var workflowActivity = new WorkflowEngine(new VideoUploading());
            workflowActivity.Run();
        }
    }
}
