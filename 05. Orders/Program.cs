﻿using System;

namespace _05._Orders
{
    internal class Program
    {
        static void SubTotal(double quantity, string product)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            Console.WriteLine($"{price*quantity:f2}");
        }

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            SubTotal(quantity, product);
        }
    }
}
