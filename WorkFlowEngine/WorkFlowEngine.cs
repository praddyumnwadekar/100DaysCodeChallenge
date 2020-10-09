using System;
using System.Collections.Generic;

namespace WorkFlow_Engine
{
    public class WorkFlowEngine
    {
        
        public void Run(IWorkFlow workFlow)
        {
            if (workFlow == null)
                throw new ArgumentNullException("Please Provide the WorkFlow");

            foreach (var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
