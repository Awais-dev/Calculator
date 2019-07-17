using System;

namespace Calculatorproject.Operators
{
    public class Addition
    {
        public void Test(string value)
        {          
            var symbolIndex = value.IndexOf("+");
            var firstNumberString = value.Substring(0, symbolIndex);
            var secondNumberString = value.Substring(symbolIndex +1);

            if (int.TryParse(firstNumberString, out var numberOne) && int.TryParse(secondNumberString, out var numberTwo))
            {
                Console.WriteLine(numberOne + numberTwo);
            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }
        }
    }
}