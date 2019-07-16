using System;

namespace Calculatorproject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCalculator Project\r");

            var firstnum = 0M;
            string enteredOperator = string.Empty;

            bool firstNumberValid = false;
            while (!firstNumberValid)
            {
                Console.WriteLine("Enter First Number\n");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out firstnum))
                {
                    firstNumberValid = true;
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            }

            bool operatorValid = false;
            while (!operatorValid)
            {
                Console.WriteLine("Select an operator\n");
                enteredOperator = Console.ReadLine();
                if (enteredOperator == "+")
                {
                    operatorValid = true;
                }
                else if (enteredOperator == "-")
                {
                    operatorValid = true;
                }

                else if (enteredOperator == "*")
                {
                    operatorValid = true;
                }

                else if (enteredOperator == "/")
                {
                    operatorValid = true;
                }
                else
                {
                    Console.WriteLine("Not an Operator");
                }

            }

            var secondnum = 0M;
            
            bool secondnumValid = false;
            while (!secondnumValid)
            {
                Console.WriteLine("Enter Second Number\n");
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out secondnum))
                {
                    secondnumValid = true;
                }
                else
                {
                    Console.WriteLine("Not a number");
                }
            }

            decimal answer;

            if (enteredOperator == "+")
            {
                answer = firstnum + secondnum;
                Console.Write(answer);
            }
            if (enteredOperator == "-")
            {
                answer = firstnum - secondnum;
                Console.Write(answer);
            }
            if (enteredOperator == "*")
            {
                answer = firstnum * secondnum;
                Console.Write(answer);
            }
            if (enteredOperator == "/")
            {
                answer = firstnum / secondnum;
                Console.Write(answer);
            }


            Console.ReadKey();

        }
    }
}

