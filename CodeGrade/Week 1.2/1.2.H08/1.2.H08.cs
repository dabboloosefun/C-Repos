using System;

namespace CodeGrade
{
    class GradeRetaker
    {
        static void Main()
        {
            List<double> grades = new List<double> {6.5, 9.5, 4, 5, 4.5, 10, 7.1};
            for (int index = 0; index < grades.Count; index++)
            {
                Console.WriteLine($"Grade: {grades[index]}");
                if (grades[index] < 5.5)
                {
                    string retake;
                    do
                    {
                        Console.WriteLine("Would you like to retake the test?");
                        retake = Console.ReadLine().ToLower();
                    } while (retake != "n" && retake != "y");
                    grades[index] = retake == "y" ? grades[index] + 1 : grades[index]; 
                }
            }
            Console.WriteLine("Final grades:");
            foreach (double element in grades)
            {
                Console.WriteLine(element);
            }
        }
    }
}