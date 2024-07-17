using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class Ordering
    {
        public Ordering(int[] input, string orderBy) 
        {
            List<int> myList = new List<int>();
            foreach (int i in input)
            {
                myList.Add(i);
            }
            if (orderBy.ToLower() == "ascending")
            {
                myList.Sort();
            }
            else
            {
                myList.Reverse();
            }
        }
    }
}
