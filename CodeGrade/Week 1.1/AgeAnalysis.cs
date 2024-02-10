using System;

namespace CodeGrade
{
    class AgeAnalysis
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string StrAge = Console.ReadLine();
            int Age = Convert.ToInt32(StrAge);
            Console.WriteLine($"You are {Age}. That's old enough to program!");
            Console.WriteLine("Last year you were " + (Age-1));
            Console.WriteLine("Next year you will be " + (Age + 1));
            Console.WriteLine("At double your age you will be " + (Age*2));
            Console.WriteLine("Next year, double your age will be " + ((Age+1) * 2));
            Console.WriteLine("Half your age is " + (Age / 2.0));
            Console.WriteLine("Half your age (rounded down) is " + (Age / 2));
            Console.WriteLine("The last digit of your age is " + (Age % 10));
        }
    }
}