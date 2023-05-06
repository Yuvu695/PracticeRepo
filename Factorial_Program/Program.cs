using System;

namespace Factorial_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int i ;
            int num = Convert.ToInt32(Console.ReadLine());
            for ( i=1 ; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
