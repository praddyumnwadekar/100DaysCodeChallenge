using System;
using System.Threading;


namespace WorkFlow_Engine
{
    public class VideoEncoder : IActivity
    {
        public void Execute()
        {
           System.Console.WriteLine("The process for  video encoding is start very soon.............\n");
            Thread.Sleep(1000);
            Console.WriteLine("Process has been Started");
            Thread.Sleep(10000);
            System.Console.WriteLine("Thank you for waiting.Your video  is ready for Encoding.\n");

        }
    }
}

