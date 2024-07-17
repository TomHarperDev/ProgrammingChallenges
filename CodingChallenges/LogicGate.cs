using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class LogicGate
    {
        public LogicGate(string Operator, bool Input1, bool Input2) 
        {
            bool anwser = false;
            switch (Operator.ToLower())
            {
                case "or":
                    anwser = (Input1 || Input2) ? true : false;
                    break;

                case "and":
                    anwser = (Input1 && Input2) ? true : false;
                    break;

                case "xor":
                    anwser = (Input1 != Input2) ? true : false;
                    break;

                case "nand":
                    anwser = !(Input1 && Input2) ? true : false;
                    break;

                case "nor":
                    anwser = !(Input1 || Input2) ? true : false;
                    break;

                default:
                    Console.WriteLine("Please enter a valid operator (or, and, xor, nand or nor)");
                    break;
            }
            Console.WriteLine(anwser);

            
        }
    }
}
