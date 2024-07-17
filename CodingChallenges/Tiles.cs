using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class Tiles
    {
        public Tiles(decimal width, decimal height, decimal cost) 
        { 
            decimal totalArea = width * height;

            totalArea = (totalArea % 10 > 0) ? totalArea + 1 : totalArea;

            int tiles = totalArea
        }

    }
}
