using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Math_Operations(num1,oper,num2));
        }
        static int Math_Operations(int num1, string oper, int num2)
        {
            int result = 0;
            switch (oper)
            {
                case "/":
                    result = num1 / num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
            }
            return result;
        }
    }
}
