using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _3_Thief
    {
        public _3_Thief() 
        {
            char[] chars = { '1', '2', '3', '4'};
            Console.WriteLine(Swap(chars, , ));
            Console.WriteLine(Swap(chars, , ));
            Console.WriteLine(Swap(chars, , ));
            Console.WriteLine(Swap(chars, , ));
            Console.WriteLine(Swap(chars, , ));
            Console.WriteLine(Swap(chars, , ));
        }






        public char[] Swap(char[] chars, int num1, int num2)
        {
            char changed = chars[num1];
            chars[num1] = chars[num2];
            chars[num2] = changed;
            return chars;
        }




        //public char[] permutation(char[] originalChars, int posToMove)
        //{
        //    char[] permuatationChars = originalChars;
            
        //    for (int i = 0; i < originalChars.Length; i++)
        //    {
        //        if (permuatationChars[i] == originalChars[i])
        //        {
        //            continue;
        //        }
        //        permuatationChars[i] = Convert.ToChar(posToMove);
        //        break;
        //    }
        //    return permuatationChars;

        //}
    }
}
