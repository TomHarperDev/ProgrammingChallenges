using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class FruitMachine
    {
        public FruitMachine() 
        {

            //string[] fruits = new string[] { "🍇", "🍍", "🍓", "☠" };
            string[] fruits = new string[] { "4", "3", "2", "1" };
            decimal credit = 1;

            string[] output = new string[3];


            while (credit != 0)
            {
                Console.WriteLine($"Credit is: {credit}");

                Console.WriteLine("Do you want to play?");

                if (Console.ReadLine().Contains("e")) 
                {
                    credit -= 0.2m;

                    Random random = new Random();
                    output[0] = fruits[random.Next(fruits.Length)];
                    output[1] = fruits[random.Next(fruits.Length)];
                    output[2] = fruits[random.Next(fruits.Length)];


                    Console.WriteLine($"The outputs are \n{output[0]} + {output[1]} + {output[2]}");

                    if (output[0] == output[1] && output[1] == output[2] && output[1] != "☠")
                    {
                        credit += 3;
                        if (output[0] == "🍓")
                        {
                            credit += 2;
                        }
                    }

                    if (output[0] == output[1] || output[0] == output[2] || output[1] == output[2])
                    {
                        credit += 0.5m;
                    }
                    credit = (fruits.Count(item => item == fruits[3]) >= 2) ? credit -= 1 : credit;
                    credit = (fruits.Count(item => item == fruits[3]) >= 3) ? credit -= credit : credit;

                    Console.WriteLine($"Credit is now: {credit}");


                }
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
