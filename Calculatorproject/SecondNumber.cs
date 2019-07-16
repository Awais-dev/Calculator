using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatorproject
{
    public class SecondNumber
    {
        decimal secondnum;
        public decimal Secondnumbercall()
        {
            

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


            return secondnum;
        }
    

        
    }
}
