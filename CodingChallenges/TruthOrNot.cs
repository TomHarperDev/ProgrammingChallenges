using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class TruthOrNot
    {
        public TruthOrNot(int inputLength)
        {
            //gets the number of binary inputs in the number
            Console.WriteLine("Rows needed: " + Math.Pow(2, inputLength));
            Console.WriteLine(ConvertToBinary(inputLength));


            for (int i = 0; i < Math.Pow(2, inputLength); i++)
            {
                Console.WriteLine(ConvertToBinary(i));
            }

        }
        public string ConvertToBinary(int num)
        {
            StringBuilder outputs = new StringBuilder();

            while (num != 0)
            {
                outputs.Append(Convert.ToString(num % 2));
                num = Convert.ToInt32(num / 2);
            }
            return new string(outputs.ToString().Reverse().ToArray());
        }
    }
}
