using System;
using static System.Console;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "ThePrimaryThread";
            WriteLine($"ID of current thread: { primaryThread.ManagedThreadId}");
            WriteLine($"Thread name: { primaryThread.Name}");
            WriteLine($"Has thread started ?  {primaryThread.IsAlive}");
            WriteLine($"Priority level:  {primaryThread.Priority}");
            WriteLine($"Thread state:  {primaryThread.ThreadState}");
            ReadLine();
        }
    }
}
