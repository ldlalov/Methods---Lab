using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Repead_String(string str, int times)
        {
            for (int i = 0; i < times; i++)
            {
            Console.Write(str);
            }
        }
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int times1 = int.Parse(Console.ReadLine());
            Repead_String(str1, times1);    
        }
    }
}
