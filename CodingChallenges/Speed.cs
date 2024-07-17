using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class Speed
    {
        public Speed(decimal seconds) 
        {
            Console.WriteLine(1 / (seconds/3600) + "Miles per hour");
        }
    }
}
