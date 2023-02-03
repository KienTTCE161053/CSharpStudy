using System;
using System.Threading;

namespace ConsoleApp3
{
    class MyParams
    {
        public int value01 { get; set; }
        public int value02 { get; set; }
    }
    internal class Program
    {   
        static AutoResetEvent waitHandel = new AutoResetEvent(false);
        static void AddNumber(object data)
        {
            if (data is MyParams p)
            {
                Thread.Sleep(1000);
                Console.WriteLine("ID of thread in Add(): {0}",Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine($"{p.value01} + {p.value02} = {p.value01 + p.value02}");
                waitHandel.Set();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ID of thread in Main() : {0}",Thread.CurrentThread.ManagedThreadId);
            MyParams p = new MyParams { value01 = 5, value02 = 15 };
            //a delegate
            Thread t = new Thread(new ParameterizedThreadStart(AddNumber));
            //to set backgound thread
            t.IsBackground= true;
            t.Start(p);
            //Wait for the wait handle to complete
            waitHandel.WaitOne();
            Console.WriteLine("Main thread: Done");
            Console.ReadLine(); 
        }
    }
}
