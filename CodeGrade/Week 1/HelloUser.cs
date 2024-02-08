using System;

namespace CodeGrade
{
    class HelloUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, please input your last name:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Please enter your initials:");
            string StringInitial = Console.ReadLine();
            char Initial = Convert.ToChar(StringInitial);
            Console.WriteLine($"Welcome to the course, {StringInitial} {Surname}. We will watch your career with great interest.");
        }
    }
}
