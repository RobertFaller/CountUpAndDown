using System;
using System.Collections.Generic;
using System.Text;

namespace CountUpAndDown
{
    class CountUp
    {
        public static void Up(int N)
        {
            int i = 1;
            if (i <= N)
            {
                return;
            }
            else
            {
                Console.WriteLine(i + " ");
                i++;
                Up(i);
            }
        }
    }
}
