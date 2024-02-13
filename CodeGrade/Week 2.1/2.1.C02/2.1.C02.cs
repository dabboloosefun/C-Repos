using System;

namespace CodeGrade
{
    class Squared
    {
        public static void Main()
        {
            int pow = Pow2(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(pow);
        }
        public static int Pow2(int number)
        {
            int pow = number * number;
            return pow;
        }
    }
}