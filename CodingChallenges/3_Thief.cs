using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _3_Thief
    {
        public _3_Thief(char[] chars) 
        {
            int pinLength = chars.Length;
            Permuatations(chars, 0, pinLength - 1);
        }

        public void Permuatations(char[] chars, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(chars);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    chars = Swap(chars, left, i);
                    Permuatations((char[])chars, left + 1, right);
                    chars = Swap(chars, left, i);
                }
            }
        }

        public char[] Swap(char[] chars, int num1, int num2)
        {
            char changed = chars[num1];
            chars[num1] = chars[num2];
            chars[num2] = changed;
            return chars;
        }
    }
}
