using System;

namespace CodeGrade
{
    class LengthyLingo
    {
        Console.WriteLine("Guess the following word: Le___th");
        string Guess = Console.ReadLine();
        string GuessLower = Guess.ToLower();
        string Answer = "Length";
        if Guess == Answer
        {
            Console.WriteLine("Correct!");
        }
        else if GuessLower == Answer
        {
            Console.WriteLine("Kind of correct. The case is just wrong.");
        }
        else if Guess.Length() > 6
        {
            Console.WriteLine("Incorrect! That's not even a six letter word!");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
        
    }
}