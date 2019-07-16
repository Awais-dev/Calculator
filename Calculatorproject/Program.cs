using System;

namespace Calculatorproject
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCalculator Project\r");

            var firstNumber = new FirstNumber();
            var firstnum = firstNumber.Firstnumbercall();

            var operatorsymbol = new Operator();
            var ops = operatorsymbol.OperatorCall();

            var secondNumber = new SecondNumber();
            var secondnum = secondNumber.Secondnumbercall();

            decimal answer;

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
        }
    }
}