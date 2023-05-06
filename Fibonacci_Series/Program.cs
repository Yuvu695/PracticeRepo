using System;

namespace Fibonacci_Series
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int prevnum = 0;
            int nextNum = 1;
            int sum = 0;
            int num = 13;
            for (int i = 0; i < num; i++)
            {
                sum = prevnum + nextNum;
                if (sum >= 100)
                {
                    break;
                }
                Console.WriteLine(sum);
                prevnum = nextNum;
                nextNum = sum;
                
                
            }
            
        }
    }
}
