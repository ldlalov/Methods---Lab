using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Add(double number1, double number2)
        {
            Console.WriteLine(number1 + number2);
        }
        static void Multiply(double number1, double number2)
        {
            Console.WriteLine(number1 * number2);
        }
        static void Subtract(double number1, double number2)
        {
            Console.WriteLine(number1 - number2);
        }
        static void Divide(double number1, double number2)
        {
            Console.WriteLine(number1 / number2);
        }
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":
                    Add(number1, number2);
                    break;
                case "multiply":
                    Multiply(number1, number2);
                    break;
                case "subtract":
                    Subtract(number1, number2);
                    break;
                case "divide":
                    Divide(number1, number2);
                    break;
            }
        }
    }
}
