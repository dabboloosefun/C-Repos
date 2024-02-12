using System;

namespace CodeGrade
{
    class NumberTable
    {
        static void Main()
        {
            Console.WriteLine("Give a number from 2-9:");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());
            if (chosenNumber < 2) chosenNumber = 2;
            if (chosenNumber > 9) chosenNumber = 9; 
            for (int i = 0; i <= chosenNumber; i++)
            {
                for (int num = 0; num <= chosenNumber; num++)
                {
                    if (i == 0)
                    {
                        Console.Write(num == 0 ? "  |" : $"{(Convert.ToString(num)).PadLeft(4)}");
                    }
                    else
                    {
                        Console.Write(num == 0 ? $"{i} |" : $"{(Convert.ToString(i * num)).PadLeft(4)}");
                    }
                }
                if (i == 0)
                {
                    Console.WriteLine();
                    for (int num = 0; num <= chosenNumber; num++)
                    {
                        Console.Write("----");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}