using System;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Thread [] threads = new Thread[5];
            ClassCounter myCounter = new ClassCounter();
            Handler myHandler = new Handler();
            Object locker = new object();
            myCounter.onCount += myHandler.Message;

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(myCounter.Counter);
                threads[i].Name = i.ToString();
            }

            lock (locker)
            {
                foreach (Thread t in threads)
                {
                    t.Start();
                }
            }

            Console.ReadLine();
        }
    }
}
