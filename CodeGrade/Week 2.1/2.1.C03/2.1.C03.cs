using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace CodeGrade
{
    class ExpressionBodies
    {
        public static void Main()
        {
            Console.WriteLine("What is your first name?");
            string? firstName = Console.ReadLine();
            Console.WriteLine("What is your second name?");
            string? lastName = Console.ReadLine();
            DisplayName(firstName, lastName);
        }
        public static string Name(string firstName, string lastName) => firstName + " " + lastName;
        public static void DisplayName(string firstName, string lastName) => Console.WriteLine(Name(firstName, lastName));
    }
}