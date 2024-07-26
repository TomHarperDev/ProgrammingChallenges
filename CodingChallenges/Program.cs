using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            happyNumber(19);
            Console.ReadLine();
        }
        public static void happyNumber(int num)
        {
            List<int> list = new List<int>();
            list.Add(num % 10);
            list.Add((num / 10) % 10);
            num = 0;
            foreach (int i in list)
            {
                num = num + i * i;
                //Console.WriteLine(i);
                //Console.WriteLine(i*i);
            }
            Console.WriteLine(num);
            if (isHappyNumber(num) == true)
            {
                Console.WriteLine("Well done this is a happy number");
            }
            else
            {
                Console.WriteLine("Iterate again");
                Console.ReadLine();
                happyNumber(num);
            }
        }
        public static bool isHappyNumber(int num)
        {
            List<int> digits = new List<int>();
            digits.Add(num % 10);
            digits.Add((num / 10) % 10);
            digits.Add((num / 100) % 10);

            if (digits.Sum() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
    }
   
}
