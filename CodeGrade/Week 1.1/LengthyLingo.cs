using System;

namespace CodeGrade
{
    class LengthyLingo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the following word: Le___th");
            string Guess = Console.ReadLine();
            string GuessLower = Guess.ToLower();
            string Answer = "Length";

            if (Guess == Answer)
            {
                Console.WriteLine("Correct!");
            }
            else if (GuessLower == "length")
            {
                Console.WriteLine("Kind of correct; the case was just wrong.");
            }
            else if (Guess.Length != 6)
            {
                Console.WriteLine("Incorrect! That is not even a six-letter word!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
    }
}