namespace Workflow_Engine
{
    class WorkflowEngine
    {
        public static void Run(Workflow workflow)
        {
            foreach (var item in workflow.Items)
            {
                item.Execute();
            }
        }
    }
}
