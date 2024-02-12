using System;

namespace CodeGrade
{
    class AutoPayer
    {
        static void Main()
        {
            Console.WriteLine("What is the amount to pay?");
            int amountTotal = Convert.ToInt32(Console.ReadLine());
            int amountLeft = amountTotal;
            while (amountLeft > 0)
            {
                Console.WriteLine($"{amountLeft} left to pay");
                Console.WriteLine("Pay how much?\n1: 5\n2: 10\n3: 20\n4: 50");
                int payedAmount = Convert.ToInt32(Console.ReadLine()) switch
                {
                    1 => 5,
                    2 => 10,
                    3 => 20,
                    4 => 50,
                    _ => 0
                };
                if (payedAmount > amountLeft)
                {
                    Console.WriteLine($"You paid {payedAmount} too much. Give a tip? y/n");
                    string? tip = Console.ReadLine().ToLower();
                    Console.WriteLine(tip == "y" ? $"You have paid {amountTotal + (payedAmount - amountLeft)}" : $"You have paid {amountTotal}");
                    amountLeft = 0;
                }
                if (payedAmount == amountLeft)
                {
                    Console.WriteLine($"You have paid {amountTotal}");
                }
                amountLeft -= payedAmount;
            }
        }
    }
}