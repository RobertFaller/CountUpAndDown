using System;
using System.Collections.Generic;
using System.Text;

namespace CountUpAndDown
{
    public class CountDown
    {
        public static void Down(int N)
        {
            if(N <= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(N + " ");
                Down(N - 1);
            }

        }
    }
}
