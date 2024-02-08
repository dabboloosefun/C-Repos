using System;

namespace CodeGrade
{
    class CelToFahr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Celsius?");
            string Input = Console.ReadLine();
            double Celsius = Convert.ToDouble(Input);
            double Fahrenheit = ((Celsius * 1.8) + 32);
            Console.WriteLine($"{Celsius} C = {Fahrenheit} F");
            double TruncFahr = Math.Truncate(Fahrenheit);
            Console.WriteLine($"Truncated that is {TruncFahr} F");
        }
    }
}