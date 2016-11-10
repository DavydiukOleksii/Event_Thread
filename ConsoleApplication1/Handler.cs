using System;
using System.Threading;

namespace ConsoleApplication1
{
    public class Handler
    {
        public void Message()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " The Count() is worked;");
        }
    }
}
