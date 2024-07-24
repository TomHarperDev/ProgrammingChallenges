using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _7_CreditCardValidator
    {
        public _7_CreditCardValidator(int[] digits) 
        {
            for(int i = digits.Length - 1; i >= 0; i -= 2)
            {
                digits[i] = (digits[i] * 2 >= 10) ? (digits[i] * 2) - 9 : digits[i] * 2;
            }

            int sum = 0;
            foreach (var item in digits)
            {
                sum += item;
            }

            string output = (sum % 10 != 0) ? "Invalid Credit Card Number" : "Invalid Credit Card Number";
            Console.WriteLine(output);
        }
    }
}
