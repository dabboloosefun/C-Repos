using System;
using System.Runtime.CompilerServices;


class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        //Your code goes here
        string? confirm = null;
            while (true)
            {
                Console.WriteLine("Are you sure? y/n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    confirm = "y";
                    break;
                }
            }

        if (confirm == "y")
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        }
    }
}