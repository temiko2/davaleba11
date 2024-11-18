using System;
using System.Diagnostics.Metrics;

namespace Task_11
{
    public class Program
    {
        static void Main(string[] args)

        {
            Counter counter1 = new Counter();
            Console.WriteLine("1: " + Counter.GetCount());
            Counter counter2 = new Counter();
            Console.WriteLine("2: " + Counter.GetCount());
            Counter counter3 = new Counter();
            Console.WriteLine("3: " + Counter.GetCount());
            Counter.ResetCount();
            Console.WriteLine("reset: " + Counter.GetCount());

        }
    }
}
