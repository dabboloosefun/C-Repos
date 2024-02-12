using System;
using System.Collections.Generic;

namespace CodeGrade
{
    class DiceRiller
    {
        static void Main()
        {
            Random rdm = new Random();
            for (int roll = 0;roll < 7;roll ++)
            {
                int diceRoll = rdm.Next(1,7);
                Console.WriteLine(diceRoll);
            }

        }
    }
}