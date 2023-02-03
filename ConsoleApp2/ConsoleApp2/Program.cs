using System;
using static System.Console;
using System.Threading;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp2
{

    internal class Program
    {
        public class Printer{
            public void PrintNumber()
            {
            Console.WriteLine($"{Thread.CurrentThread.Name} is exe PrintNumbers()");
            //print out number
            for (int i =1; i <= 5; i++)
                {
                    Console.WriteLine($"Second Thread: {i}");
                    Thread.Sleep(2000);
                }
                Console.WriteLine("The second thread has finished");
            }
        }
    static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine($"{Thread.CurrentThread.Name} is executing Main()");
            //step 02
            Printer p = new Printer(); 
            //step 03
            Thread backgoundThread = new Thread(new ThreadStart(p.PrintNumber));
            //step 04
            backgoundThread.Name = "Secondary";
            //step 05
            backgoundThread.Start();
            //Do some addition work
            for (int i = 1;i <= 5; i++)
            {
                Console.WriteLine($"Main thread : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("The main thread has finished");
            Console.ReadLine();
        }
    }
}
