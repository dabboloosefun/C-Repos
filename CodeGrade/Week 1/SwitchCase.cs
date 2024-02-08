using System;

namespace CodeGrade
{
    class SwitchCase
    {
        static void Main()
        {
            Console.WriteLine("Which direction?");
            string direction = Console.ReadLine().ToLower();
            int X = 0
            int Y = 0
            switch (direction)
            {
                case "up":
                    Y += 1;
                    break;
                case "left":
                    X -= 1;
                    break;
                case "down":
                    Y -= 1;
                    break;
                case "right":
                    X += 1;
                    break;
                default:
                    Console.WriteLine("Invalid direction");
                    break;
            }
            Console.WriteLine("Current position")
            Console.WriteLine($"X : {X}, Y : {Y}")
        }
    }
}