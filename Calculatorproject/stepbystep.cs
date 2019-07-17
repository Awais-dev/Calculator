using System;

namespace Calculatorproject
{
    public class StepByStep
    {
        public void Stepcall()
        {
            Console.WriteLine("\t\t\tCalculator Project\r");

            var firstNumber = new FirstNumber();
            var firstnum = firstNumber.Firstnumbercall();

            var operatorsymbol = new Operator();
            var ops = operatorsymbol.OperatorCall();

            var secondNumber = new SecondNumber();
            var secondnum = secondNumber.Secondnumbercall();

            decimal answer = 0M;

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
