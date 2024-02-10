using System;

namespace CodeGrade
{
    class SeasonSelect
    {
        static void Main()
        {
            Console.WriteLine("Input a month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a day:");
            int day = Convert.ToInt32(Console.ReadLine());
            string season = month switch
            {
                1 or 2 => "Winter",
                3 => day >= 21 ? "Spring" : "Winter",
                4 or 5 => "Spring",
                6 => day >= 21 ? "Summer" : "Spring",
                7 or 8 => "Summer",
                9 => day >= 21 ? "Autumn" : "Summer",
                10 or 11 => "Autumn",
                12 => day >= 21 ? "Winter" : "Autumn"
            };
            Console.WriteLine($"On {day}-{month} it is {season}");
        }
    }
}