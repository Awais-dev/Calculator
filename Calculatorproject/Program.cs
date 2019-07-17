using Calculatorproject.Operators;
using System;

namespace Calculatorproject
{       
    public class Program
    {
        private static void Main()
        {
            //var stepbystep = new StepByStep();s
            //stepbystep.Stepcall();

            //var oneline = new OneLine();
            //oneline.Equation();

            var input = Console.ReadLine();

            if(input.Contains("+"))
            {
                var addition = new Addition();
                addition.Test(input);
            }

            Console.ReadKey();
        }
    }
}