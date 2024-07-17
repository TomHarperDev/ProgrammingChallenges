using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class RandomPassword
    {
        
        public RandomPassword(int length)
        {
            string characters = "abcdefghijklmnopqrstuvwxyz1234567890";
            Random random = new Random();

            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                password.Append(characters[random.Next(characters.Length)]);
            }
            Console.WriteLine(password.ToString());
        }
    }
}
