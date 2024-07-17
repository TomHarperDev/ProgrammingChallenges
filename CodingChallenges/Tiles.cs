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

            int tiles = Convert.ToInt32(totalArea);

            Console.WriteLine($"Number of tiles is: {tiles}");


            Console.WriteLine($"Cost of tiles is: {tiles*cost}");
        }

    }
}
