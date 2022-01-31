using System;

namespace _02._Grades
{
    internal class Program
    {
        static void Grade_definition(double grade)
        {
            if (2<=grade && grade<=2.99)
            {
                Console.WriteLine("Fail");
            }
            if (3<=grade && grade<=3.49)
            {
                Console.WriteLine("Poor");
            }
            if (3.50<=grade && grade<=4.49)
            {
                Console.WriteLine("Good");
            }
            if (4.50<=grade && grade<=5.49)
            {
                Console.WriteLine("Very good");
            }
            if (5.50<=grade && grade<=6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grade_definition(grade);    
        }
    }
}
