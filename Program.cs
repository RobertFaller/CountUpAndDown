using System;

namespace CountUpAndDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 9;
            Console.WriteLine("Counting up");
            CountUp.Up(N);
            Console.WriteLine("Counting down");
            CountDown.Down(N);
            Console.WriteLine("Hello World!");
        }
    }
}
