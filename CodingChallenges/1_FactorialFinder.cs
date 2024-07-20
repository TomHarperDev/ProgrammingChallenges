using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _1_FactorialFinder
    {
        public _1_FactorialFinder()
        {
            Console.WriteLine("Please enter a number to find a factorial of: ");
            Console.WriteLine(Factorial(Convert.ToInt32(Console.ReadLine())));
        }

        public int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}
