using System;

namespace CodeGrade
{
    class PassedCounter
    {
        static void Main()
        {
            List<double> grades = new List<double> {7, 5.5, 3.2, 10, 4.5};
            int passedStudents = 0;
            foreach (double element in grades)
            {
                if (element >= 5.5) passedStudents++;
            }
            Console.WriteLine($"{passedStudents} out of {grades.Count()} students passed.");
        }
    }
}