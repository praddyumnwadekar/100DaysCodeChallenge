using System.Threading;

namespace WorkFlow_Engine
{

    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("The process is initialise for video uploading.............\n");
            Thread.Sleep(10000);
            System.Console.WriteLine("Video Uploaded Successfully.\n");
        }
    }
}

