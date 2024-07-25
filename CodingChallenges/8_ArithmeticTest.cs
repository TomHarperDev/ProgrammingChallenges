using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    internal class _8_ArithmeticTest
    {
        private Random random = new Random();
        private int total = 0;
        public _8_ArithmeticTest() 
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Question {i}");
                GenerateQuestion();
            }
            Console.WriteLine($"Your score is {total}");
        }

        public void GenerateQuestion()
        {
            string[] operators = { "+", "-", "/", "*" };

            int num1 = random.Next(1, 20);
            int num2 = random.Next(1, 20);

            string operation = operators[random.Next(operators.Length)];
            Console.WriteLine($"Your question is {num1} {operation} {num2} please anwser to 2 decimal places:");
            decimal anwser = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine(CheckAnwser(operation, num1, num2, anwser));
        }
        public bool CheckAnwser(string operation, int num1, int num2, decimal anwser)
        {
            bool result = false;
            switch (operation)
            {
                case "+":
                    result = (num1 + num2 == Convert.ToDecimal(anwser)) ? true: false ; 
                    break;
                case "-":
                    result = (num1 - num2 == Convert.ToDecimal(anwser)) ? true : false;
                    break;
                case "*":
                    result = (num1 * num2 == Convert.ToDecimal(anwser)) ? true : false;
                    break;
                case "/":
                    result = (Math.Round((decimal)num1 / num2, 2) == anwser) ? true : false;
                    break;
            }
            if (result)
            {
                total++;
            }
            return result;
        }
    }
}
