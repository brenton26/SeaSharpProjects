using System.Collections.Generic;

namespace Workflow_Engine
{
    public class Workflow
    {
        public List<IActivity> Items = new List<IActivity>();
        
        public Workflow(params IActivity[] activities)
        {
            foreach (var item in activities)
            {
                Items.Add(item);
            }
        }
    }
}