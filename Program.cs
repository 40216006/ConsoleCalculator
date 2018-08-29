using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = 0;

            double result = 0;

            Console.WriteLine("Type your first number:");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);

            Console.WriteLine("Type your second number :");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);

            Console.WriteLine("Enter the operation + (addition), -(subtraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");

            string stringOperation = Console.ReadLine();

            if(stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "subtraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }
            else if (stringOperation == "^" || stringOperation == "exposant")
            {
                operation = 5;
            }
            else if (stringOperation == "%" || stringOperation == "reste")
            {
                operation = 6;
            }

            switch (operation)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;

                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;

                case 4:
                    result = firstNumber / secondNumber;
                    break;

                case 5:
                    result = Math.Pow(firstNumber, secondNumber);
                    break;

                case 6:
                    result = firstNumber % secondNumber;
                    break;

            }
            Console.WriteLine("\nResult of " + firstNumber + "" + stringOperation + "" + secondNumber + "=" + result + ".");
            Console.ReadKey();
        }
    }
}
