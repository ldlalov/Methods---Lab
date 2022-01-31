using System;
using System.Linq;

namespace Methods___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ").ToArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(string.Join("", $"{ arr[i]} "));
            }
        }
    }
}
