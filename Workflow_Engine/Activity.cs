namespace Workflow_Engine
{
    public interface IActivity
    {
        void Execute();
    }

    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Video upload completed.");
        }
    }
    public class WebServiceCall : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Web service call completed.");
        }
    }
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Email sent.");
        }
    }
    public class ChangeVideoStatus : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Video status changed.");
        }
    }
}