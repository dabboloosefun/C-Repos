using System;
using System.Collections.Generic;

namespace CodeGrade
{
    class ListLearning
    {
        static void Main()
        {
            List<string> myList = new List<string> {};
            Console.WriteLine($"Amount of tasks: {myList.Count()}");
            foreach (string task in myList)
            {
                Console.WriteLine(task);
            }
            myList.Add("Mow lawn"); myList.Add("Pay taxes");
            Console.WriteLine($"Amount of tasks: {myList.Count()}");
            foreach (string task in myList)
            {
                Console.WriteLine(task);
            }
            myList.Remove("Mow lawn");
            myList.Add("Shopping");
            Console.WriteLine($"Amount of tasks: {myList.Count()}");
            foreach (string task in myList)
            {
                Console.WriteLine(task);
            } 
        }
    }
}