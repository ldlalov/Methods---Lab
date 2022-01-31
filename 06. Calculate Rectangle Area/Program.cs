using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static int Rectangle_Area(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());  
            int b = int.Parse(Console.ReadLine());  
            Console.WriteLine(Rectangle_Area(a, b));
        }
    }
}
