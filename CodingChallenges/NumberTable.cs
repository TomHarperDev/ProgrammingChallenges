using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class NumberTable
    {
        public NumberTable(int number) 
        {
            StringBuilder row = new StringBuilder();
            number++;
            int incrementer  = 0;
            for (int j = 0; j < number; j++)
            {
                for (int i = 0; i < number; i++)
                {
                    row.Append(" " + (i + incrementer));
                }
                Console.WriteLine(Convert.ToString(row));
                row.Clear();
                incrementer++;
            }
        }
    }
}
