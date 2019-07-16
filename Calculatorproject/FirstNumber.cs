using System;

namespace Calculatorproject
{
    public class FirstNumber
    {
        decimal firstnum;

        public decimal Firstnumbercall()
        {
            
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
            return firstnum;
        }
    }
}
