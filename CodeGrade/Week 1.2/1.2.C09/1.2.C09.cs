using System;

namespace CodeGrade
{
    class BossAttacker
    {
        static void Main()
        {
            int attack = 50;
            double critChance = 0.33;
            int bossHP = 1000;
            Random rnd = new Random();
            while (bossHP > 0)
            {
                double critRoll = rnd.NextDouble();
                int attackRoll = critRoll > critChance ? attack : attack * 2;
                Console.WriteLine($"Boss HP: {bossHP}\nDamage: {attackRoll}");
                bossHP -= attackRoll;
            }
            Console.WriteLine("Boss defeated");
        }
    }
}