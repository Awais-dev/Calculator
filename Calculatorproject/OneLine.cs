using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatorproject
{
    public class OneLine
    {
        

        public string Equation()
        {
           

            string symbol =string.Empty;
            string ops = string.Empty;
            int test = 0;
            bool firstNumberValid = false;
            bool operatorValid = false;
            while (!firstNumberValid)
            {
                Console.WriteLine("Enter Equation\n");
                var input = Console.ReadLine();

                var input2 = input.Length;

               
            if (int.TryParse(input, out int number1))
                {
                    firstNumberValid = true;
                    test = number1;
                }
                else 
                {
                    Console.WriteLine("Input is invalid");
                }
                string sub = input.Substring(0, 3);
                Console.WriteLine("Substring: {0}", sub);
                Console.WriteLine($"{input2}");


                //if (symbol == "+")
                //{
                //    Console.WriteLine(symbol);

                //    operatorValid = true;
                //    ops = symbol;
                //}
                //else if (symbol == "-")
                //{
                //    operatorValid = true;
                //    ops = symbol;
                //}

                //else if (symbol == "*")
                //{
                //    operatorValid = true;
                //    ops = symbol;
                //}

                //else if (symbol == "/")
                //{
                //    operatorValid = true;
                //    ops = symbol;
                //}



            }
            
   
            Console.WriteLine($"The equation you have inputted is {test},{symbol}");
          

            Console.ReadLine();


            return "";
        }



    }
}
