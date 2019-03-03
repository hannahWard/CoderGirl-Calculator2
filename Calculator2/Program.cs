using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            // Use methods for each type of calculation.

            Console.WriteLine("Please, enter your first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter your second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            string calculation = Console.ReadLine();

            double result = 0;

            if (calculation == "add")
            {
                result = Add(firstNumber, secondNumber);
            }
            else if (calculation == "subtract")
            {
                result = Subtract(firstNumber, secondNumber);
            }
            else if (calculation == "multiply")
            {
                result = Multiply(firstNumber, secondNumber);
            }
            else if (calculation == "divide")
            {
                result = Divide(firstNumber, secondNumber);
            }

            Console.WriteLine($"Total = {result}");
            Console.ReadLine();
        }

        public static double Add(double firstNumber, double secondNumber)
        {
            double total = firstNumber + secondNumber;
            return total;  
        }

        public static double Subtract(double firstNumber, double secondNumber)
        {
            double total = firstNumber - secondNumber;
            return total;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            double total = firstNumber * secondNumber;
            return total;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            double total = firstNumber / secondNumber;
            return total;
        }
    }
}
