using System;

namespace CodeGrade
{
    class NumberGuessr
    {
        static void Main()
        {
            Random rnd = new Random(0);
            Console.WriteLine("Time to play Guess the Number!");
            while (true)
            {
                Console.WriteLine("Give the minimum number:");
                int minimumNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give the maximum number:");
                int maximumNumber = Convert.ToInt32(Console.ReadLine());
                if (maximumNumber == minimumNumber)
                {
                    Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
                    maximumNumber++;
                }
                if (minimumNumber > maximumNumber)
                {
                    Console.WriteLine("The minimum is higher than the maximum. Switching values.");
                    int temp = minimumNumber;
                    minimumNumber = maximumNumber;
                    maximumNumber = temp;
                }
                int chosenNumber = rnd.Next(minimumNumber, (maximumNumber + 1));
                int guessedNumber;
                do
                {
                    
                    Console.WriteLine($"Guess the number [{minimumNumber}-{maximumNumber}]");
                    guessedNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessedNumber != chosenNumber) Console.WriteLine(guessedNumber > chosenNumber ? "Lower!" : "Higher!");
                }   while (guessedNumber != chosenNumber);
                Console.WriteLine($"{guessedNumber} is correct!\nDo you wish to play another round? Y to continue");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y")
                {
                    break;
                }
            }
        }
    }
}