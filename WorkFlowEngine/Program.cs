using System;
using System.Collections.Generic;

namespace WorkFlow_Engine
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Welcome To WorkFlow Engine");
            Console.WriteLine("---------------------------------------------------------------------------");

            var workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader()); 
            workFlow.Add(new VideoEncoder()); 
            workFlow.Add(new EmailSender()); 
            workFlow.Add(new StatusOfVideo());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
        }
    }
}
