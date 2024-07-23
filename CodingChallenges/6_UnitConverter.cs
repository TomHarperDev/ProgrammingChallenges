using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CodingChallenges
{
    internal class _6_UnitConverter
    {
        public _6_UnitConverter()
        {
            Console.WriteLine("Please enter a unit value");
            decimal unitValue = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter a unit category from temo, currecny or volume");
            string enteredCategory = Console.ReadLine();

            Console.WriteLine("Please enter the entered unit type");
            string enteredUnitType = Console.ReadLine();

            Console.WriteLine("Please enter a unit type to convert into");
            string desiredUnitType = Console.ReadLine();


        }

        public decimal ConvertUnit(decimal unitValue,string enteredCategroy, string enteredUnitType, string desiredUnitType)
        {
            switch (enteredCategroy)
            {
                case "temp":
                    unitValue = (enteredUnitType == "celsius " && desiredUnitType == "fahrenheit") ? (unitValue * (9/5)) + 32 : (unitValue - 32) * (5/9);
                    break;
                case "currency":
                    unitValue = (enteredUnitType == "")
                    break;


                default:
                    Console.WriteLine("Please enter a valid inputs");
                    break;
            }


            return unitValue;
        }
    }
}
