using System;
using System.Text.Encodings.Web;

namespace CodeGrade
{
    class Compass
    {
        static void Main()
        {
            Console.WriteLine("Y/N?");
            string north = Console.ReadLine();
            Console.WriteLine("Y/N?");
            string east = Console.ReadLine();
            Console.WriteLine("Y/N?");
            string south = Console.ReadLine();
            Console.WriteLine("Y/N?");
            string west = Console.ReadLine();
            Console.WriteLine("Give a baering.");
            double bearing = Convert.ToDouble(Console.ReadLine());
            while (bearing < 0 || bearing >= 360)
            {
                if (bearing < 0)
                {
                    bearing += 360;
                }
                else if (bearing >= 360)
                {
                    bearing -= 360;
                }
            }
            (bool possible, string direction) = bearing switch
            {
                > 315 or <= 45 => (north == "Y" ? true : false, "north"),
                > 45 and <= 135 => (east == "Y" ? true : false, "east"),
                > 135 and <= 225 => (south == "Y" ? true : false, "south"),
                > 225 and <= 315 => (west == "Y" ? true : false, "west")
            };
            Console.WriteLine(north == "Y" ? "    N\n    |" : "");
            Console.Write(west == "Y" ? "W---" : "    ");
            Console.Write("|");
            Console.WriteLine(east == "Y" ? "---E" : "");
            Console.WriteLine(south == "Y" ? "    |\n    S\n" : "");
            Console.WriteLine(possible ? $"You are going {direction}" : $"You can't go {direction}");

        }
    }
}