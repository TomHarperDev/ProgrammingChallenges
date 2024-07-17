using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class Palindromes
    {
        public Palindromes(string palindrome)
        {
            StringBuilder reversedString = new StringBuilder();

            for(int i = palindrome.Length - 1; i >= 0; i--)
            {
                reversedString.Append(palindrome[i]);
            }
            bool anwser = (palindrome == Convert.ToString(reversedString)) ? true : false;
            Console.WriteLine(anwser);
        }
    }
}
