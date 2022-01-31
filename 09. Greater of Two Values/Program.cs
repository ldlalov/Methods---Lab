using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static int GetMax(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }
        static char GetMax(char char1, char char2)
        {
            return (char1>char2) ? char1 : char2;
        }
        static string GetMax(string string1, string string2)
        {
            return (string1 == string2) ? string1 : string2;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    var num1 = int.Parse(Console.ReadLine());
                    var num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2)); 
                    break;
                case "char":
                    var char1 = char.Parse(Console.ReadLine());
                    var char2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(char1, char2));
                    break;
                case "string":
                    var string1 = Console.ReadLine();
                    var string2 = Console.ReadLine();
                    Console.WriteLine(GetMax(string1, string2));
                    break;
            }
        }
    }
}
