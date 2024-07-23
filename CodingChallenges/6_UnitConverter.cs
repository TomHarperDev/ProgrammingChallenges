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
            try
            {
                Console.WriteLine("Please enter a unit value");
                decimal unitValue = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter a unit category from temp, currecny or volume");
                string enteredCategory = Console.ReadLine();

                Console.WriteLine("Please enter the entered unit type");
                string enteredUnitType = Console.ReadLine();

                Console.WriteLine("Please enter a unit type to convert into");
                string desiredUnitType = Console.ReadLine();

                Console.WriteLine(ConvertUnit(unitValue, enteredCategory, enteredUnitType, desiredUnitType));
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter valid information");
            }
            


        }

        public decimal ConvertUnit(decimal unitValue,string enteredCategroy, string enteredUnitType, string desiredUnitType)
        {
            switch (enteredCategroy)
            {
                case "temp":
                    unitValue = (enteredUnitType == "celsius " && desiredUnitType == "fahrenheit") ? (unitValue * (9/5)) + 32 : (unitValue - 32) * (5/9);
                    break;
                case "currency":
                    unitValue = (enteredUnitType == "pound" && desiredUnitType == "euro") ? unitValue * 1.19m :
                                (enteredUnitType == "pound" && desiredUnitType == "dollar") ? unitValue * 1.29m :
                                (enteredUnitType == "dollar" && desiredUnitType == "pound") ? unitValue * 0.77m :
                                (enteredUnitType == "dollar" && desiredUnitType == "euro") ? unitValue * 0.92m :
                                (enteredUnitType == "euro" && desiredUnitType == "pound") ? unitValue * 0.84m :
                                (enteredUnitType == "euro" && desiredUnitType == "dollar") ? unitValue * 1.08m : unitValue;
                    break;

                case "volume":
                    unitValue = (enteredUnitType == "milliliters" && desiredUnitType == "litre") ? unitValue / 1000 :
                                (enteredUnitType == "milliliters" && desiredUnitType == "gallon") ? unitValue / 3785.41m :
                                (enteredUnitType == "litre" && desiredUnitType == "milliliters") ? unitValue * 1000 :
                                (enteredUnitType == "litre" && desiredUnitType == "gallon") ? unitValue * 3.78541m :
                                (enteredUnitType == "gallon" && desiredUnitType == "litre") ? unitValue * 3.78541m :
                                (enteredUnitType == "gallon" && desiredUnitType == "litre") ? unitValue * 3785.41m : unitValue;
                      break;

                default:
                    Console.WriteLine("Please enter a valid inputs");
                    break;
            }


            return unitValue;
        }
    }
}
