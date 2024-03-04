using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num1, num2, sum = 0;

            Console.Write("\n\n");
            Console.Write("A program that prints the sum of all multiple of 3 and 5 less than 100 : ");
            Console.Write("\n\n");
            Console.Write("-------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("The sum of all multiples of 3 and 5 are");
            Console.Write("\n\n");
            for(i = 1; i <= 100; i ++)
            {
                num1 = i % 3;
                num2 = i % 5;

                if (num1 == 0 || num2 == 0)
                    Console.Write("{0} \t" ,i);
                    sum = sum + i;
            }
            Console.Write("\n\n");
            Console.Write("The sum of all multiples of 3 and 5 less than 100 is : {0} ", sum);
            Console.ReadLine();
        }
    }
}
