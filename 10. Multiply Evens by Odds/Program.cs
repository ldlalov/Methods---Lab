using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int sumEven = GetSumOfEvenDigits(num);
            int sumOdd = GetSumOfOddDigits(num);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumEven,sumOdd));
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sumEven = 0;
            while (num  > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
                num /= 10;
            }
            return sumEven;

        }
        static int GetSumOfOddDigits(int num)
        {
            int sumOdd = 0;
            while (num  > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 1 && digit !=0)
                {
                    sumOdd += digit;
                }
                num /= 10;
            }
            return sumOdd;
        }
        static int GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            return sumEven * sumOdd;
        }

    }
}
