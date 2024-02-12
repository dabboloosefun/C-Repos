using System;

namespace CodeGrade
{
    class TaxMess
    {
        static void Main()
        {
            Console.WriteLine("balance");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("interest rate");
            double interest = 1 + (Convert.ToDouble(Console.ReadLine()) / 100);
            Console.WriteLine("years");
            int years = Convert.ToInt32(Console.ReadLine());
            double totalTax = 0;
            for (int i = years; i > 0; i--)
            {
                balance = balance * interest;
                if (balance >= 100_000)
                {
                    double tax = (balance - 100_000) * 0.03 + 750;
                    balance -= tax;
                    totalTax += tax;
                }
                else if (balance >= 50_000)
                {
                    double tax = (balance - 50_000) * 0.015;
                    balance -= tax;
                    totalTax += tax;
                }
            }
            Console.WriteLine($"Balance after {years} years: {Math.Floor(balance)}");
            Console.WriteLine($"Amount of taxes paid: {Convert.ToInt32(totalTax)}");
        }
    }
}