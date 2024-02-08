using System;

namespace CodeGrade
{
    class WaterState
    {
        static void Main()
        {
            Console.WriteLine("What is the temperature of the water.");
            double Temp = Convert.ToDouble(Console.ReadLine());
            if (Temp <= 0)
            {
                Console.WriteLine($"At {Temp} degrees Celsius, the water will be solid.");
            }
            else if (Temp >= 100)
            {
                Console.WriteLine($"At {Temp} degrees Celsius, the water will be gas.");
            }
            else
            {
                Console.WriteLine($"At {Temp} degrees Celsius, the water will be liquid.");
            }
        }
    }
}