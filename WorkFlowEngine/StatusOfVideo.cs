using System;
namespace WorkFlow_Engine
{
    public class StatusOfVideo : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Process Completed.");
        }
    }
}

