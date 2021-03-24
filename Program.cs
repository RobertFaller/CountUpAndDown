using System;

namespace CountUpAndDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 9;
            //Counting up doesn't work, under the basis that the only method i could think of
            //requires a variable to be used, but upon each call to the function it is causing
            //an infinite loop as the variable is reset back to the starting value.
            //Console.WriteLine("Counting up");
            //CountUp.Up(N);
            Console.WriteLine("Counting down");
            CountDown.Down(N);
            Console.WriteLine("I cannot think of any other method, without initiating a loop");
        }
    }
}
