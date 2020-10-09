using System;
using System.Threading;

namespace WorkFlow_Engine
{
    public class EmailSender : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an mail to the owner....\n");
            Thread.Sleep(2000);
            Console.WriteLine("Mail Sent\n");
        }
    }
}

