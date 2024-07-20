using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class ItemMerge
    {
        public ItemMerge(List<string> WeekA, List<string> WeekB) 
        {
            List<string> Unique = new List<string>();
            Unique.AddRange(WeekA);

            for (int i = 0; i < WeekB.Count; i++)
            {
                if (Unique.Contains(WeekB[i]))
                {
                    Unique.Remove(WeekB[i]);
                }
            }
            foreach (string item in Unique)
            {
                Console.WriteLine(item);
            }
        }
    }
}
