using System;
using System.Collections.Generic;
using System.Text;

namespace Calculatorproject
{
    public class Operator
    {
        string ops;
        string enteredOperator = string.Empty;
        bool operatorValid = false;

        public string OperatorCall()
        {
                 
        while (!operatorValid)
            {
                Console.WriteLine("Select an operator\n");
                enteredOperator = Console.ReadLine();
                if (enteredOperator == "+")
                {
                    operatorValid = true;
                    ops = enteredOperator;
                }
                else if (enteredOperator == "-")
                {
                    operatorValid = true;
                    ops = enteredOperator;
                }

                else if (enteredOperator == "*")
                {
                    operatorValid = true;
                    ops = enteredOperator;
                }

                else if (enteredOperator == "/")
                {
                    operatorValid = true;
                    ops = enteredOperator;
                }
                else
                {
                    Console.WriteLine("Not an Operator");
                }

            }
                return ops;
        }
    }
}
