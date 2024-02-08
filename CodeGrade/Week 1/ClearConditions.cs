using System;

namespace CodeGrade
{
    class ClearConditions
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int YourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your neighbours age?");
            int TheirAge = Convert.ToInt32(Console.ReadLine());
            if (YourAge == TheirAge)
            {
                Console.WriteLine("Your ages are equal.");
            }
            else if (YourAge > TheirAge)
            {
                Console.WriteLine("You are older.");
            }
            else
            {
                Console.WriteLine("You are younger.");
            }
        }
    }
}