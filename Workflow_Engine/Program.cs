using System;

namespace Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var activity1 = new WebServiceCall();
            var activity2 = new UploadVideo();
            var activity3 = new ChangeVideoStatus();
            var activity4 = new SendEmail();

            var workflow1 = new Workflow(activity1, activity2, activity3, activity4);
            WorkflowEngine.Run(workflow1);
        }
    }
}
