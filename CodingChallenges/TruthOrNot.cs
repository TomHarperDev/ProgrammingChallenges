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

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < Math.Pow(2, inputLength); i++)
            {
                for (int j = inputLength - 1; j >  inputLength; j--)
                {
                    if (output[j] == '0')
                    {
                        output[j] == '1';
                    }
                    break;
                }
            }
        }
    }
}
