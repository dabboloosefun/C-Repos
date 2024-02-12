using System;
using System.Formats.Asn1;

namespace CodeGrade
{
    class PincodeGuessr
    {
        static void Main()
        {
            string correct = "4567";
            string? guess = "incorrect";
            for (int i = 3; i > 0 && guess != correct; i --)
            {
                Console.WriteLine($"Enter your PIN\n{i} attempts left");
                guess = Console.ReadLine();
            }
            Console.WriteLine(guess == correct ? "Correct!" : "Your pass is confiscated.");
        }
    }
}