using System;
using System.Collections.Generic;

namespace WorkFlow_Engine
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

       public  IEnumerable<IActivity> GetActivities()
        {
            
            return _activities;
        }
    }
}
