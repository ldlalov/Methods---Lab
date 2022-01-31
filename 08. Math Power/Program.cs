using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static double Power(double number, double power)
        {
            return Math.Pow(number,power);
        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Power(number, power));
        }
    }
}
