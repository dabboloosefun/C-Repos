using System;

namespace CodeGrade
{
    class fizzBuzz
    {
        static void Main()
        {
            Console.WriteLine("First number?");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("End number");
            int endNumber = Convert.ToInt32(Console.ReadLine()) + 1;
            string moduloThree;
            string moduloFive;
            for (int i = startNumber; i < endNumber; i++)
            {
                moduloThree = i % 3 == 0 ? "Fizz" : "";
                moduloFive = i % 5 == 0 ? "Buzz" : "";
                Console.WriteLine((moduloThree == "Fizz" || moduloFive == "Buzz") ? moduloThree + moduloFive : i);
            }
        }
    }
}