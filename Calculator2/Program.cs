using System;

namespace Calculator2
{
    public static class Program
    {
        public static void Main()
        {
            //double result = 0;

            // Create a simple calculator that asks the user to input two different numbers 
            // and whether they want to add, subtract, multiply or divide them. 

            // Use methods for each type of calculation.

            Console.WriteLine("Please, enter your first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter your second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to add, subtract, multiply, or divide?");
            string calculation = Console.ReadLine();

            if (calculation == "add")
            {
                double result = Add_ReturnValue(firstNumber, secondNumber);
                Console.WriteLine($"Total = {result}");
            }
            if (calculation == "subtract")
            {
                double result = Subtract_ReturnValue(firstNumber, secondNumber);
                Console.WriteLine($"Total = {result}");
            }
            if (calculation == "*")
            {
                double result = Multiply_ReturnValue(firstNumber, secondNumber);
                Console.WriteLine($"Total = {result}");
            }
            if (calculation == "/")
            {
                double result = Divide_ReturnValue(firstNumber, secondNumber);
                Console.WriteLine($"Total = {result}");
            }


            

            Console.ReadLine();
        }

        public static double Add_ReturnValue(double firstNumber, double secondNumber)
        {
            double total = firstNumber + secondNumber;
            return total;
        }

        public static double Subtract_ReturnValue(double firstNumber, double secondNumber)
        {
            double total = firstNumber - secondNumber;
            return total;
        }

        public static double Multiply_ReturnValue(double firstNumber, double secondNumber)
        {
            double total = firstNumber * secondNumber;
            return total;
        }

        public static double Divide_ReturnValue(double firstNumber, double secondNumber)
        {
            double total = firstNumber / secondNumber;
            return total;
        }
    }
}
