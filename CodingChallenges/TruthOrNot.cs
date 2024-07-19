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

        }
        public string ConvertToBinary(int num)
        {
            StringBuilder ouputs = new StringBuilder();

            while (num != 0)
            {
                ouputs.Append(Convert.ToString(num % 2));
                num = Convert.ToInt32(num / 2);
            }
            return (Convert.ToString(ouputs));
        }
    }
}
