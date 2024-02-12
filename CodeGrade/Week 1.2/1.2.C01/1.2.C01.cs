using System;
using System.IO.Compression;

namespace CodeGrade
{
    class WhileMoney
    {
        static void Main()
        {
            int money = 4;
            while (money > 0)
            {
                Console.WriteLine($"Money left: {money}");
                Console.WriteLine("Look around (1) or go in a ride (2)?");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Yay!");
                        break;
                    case "2":
                        Console.WriteLine("Wheee!");
                        money -= 1;
                        break;
                }
            }
            Console.WriteLine("Time to go home.");
        }
    }
}