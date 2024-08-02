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
            NumToEnglish(408);
            Console.ReadLine();
        }

        public static void NumToEnglish(int num)
        {
            // this wokrs for 1-20 and can show hundreds, however, it does not work for tens above 20
            // doesnt work when any digit above 0 is in tens column - code assumes tens can only be 10-20 and not anything higher

            


            StringBuilder ouput = new StringBuilder();
            string[] ones_teens = {null, "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty", };
            string[] tens = { "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety", "One Hundred" };


            //string numOneToTwenty = " " + ones_teens[(num % 100)];
            string numOneToTwenty = (num % 100 > 0 && num > 99) ? " and " + ones_teens[(num % 100)] : ones_teens[(num % 100)];


            num /= 100;


            string numHundreds = ones_teens[num % 10] + " Hundred";


            ouput.Append(numHundreds);
            ouput.Append(numOneToTwenty);


            Console.WriteLine(Convert.ToString(ouput));







            //Console.WriteLine(num % 10);
            //Console.WriteLine(ones[num % 10 - 1]);
            //ouput.Insert(0, ones[num % 10 - 1]);

            //num /= 10;
            //Console.WriteLine(num);
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
