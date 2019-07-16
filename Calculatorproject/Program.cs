using System;

namespace Calculatorproject
{
    class Program
    {    
        public static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer;
            string ops;

            Console.WriteLine("\t\t\tCalculator Project\r");

            Console.WriteLine("Enter First Number\n" );
            firstnum = double.Parse(Console.ReadLine());

            Console.WriteLine("Select an operator\n");
            ops = Console.ReadLine();

            Console.WriteLine("Enter Second Number\n");
            secondnum = double.Parse(Console.ReadLine());

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write(answer);
            }

            if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write(answer);
            }

            if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write(answer);
            }

            if (ops == "/")
            {
                answer = firstnum / secondnum;
                Console.Write(answer);
            }

            Console.ReadKey();

        }
    }
}

