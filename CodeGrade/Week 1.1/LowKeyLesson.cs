using System;

namespace CodeGrade
{
    class LowKeyLesson
    {
        static void Main()
        {
            int correct = 0;
            Console.WriteLine(@"Answer the following MCQs:
Which of the following is NOT a valid type in C#?
A: bool
B: int
C: var
D: string");
            char answer_one = Convert.ToChar(Console.ReadLine().ToLower());
            if (answer_one == 'c')
            {
                correct += 1;
            }

            Console.WriteLine(@"What happens if you execute the following line C#?
int x = 1.23;
A: x will be 1.23
B: x will be 1
C: x will be 1.0
D: you will get a compiler error");
            char answer_two = Convert.ToChar(Console.ReadLine().ToLower());
            if (answer_two == 'd')
            {
                correct += 1;
            }

            Console.WriteLine(@"Consider the following line:
double d = 1.23;
What are TWO ways to convert variable d to an int?
A: int i = (int)d;
B: int i = int(d)
C: int i = 0 + d
D: int i = Convert.ToInt32(d)
Your first answer:");
            char answer_three = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine("Your second answer:");
            char answer_four = Convert.ToChar(Console.ReadLine().ToLower());
            if ((answer_three == 'd' && answer_four == 'a') || (answer_three == 'a' && answer_four == 'd'))
            {
                correct += 1;
            }
            string feedback = correct switch
            {
                3 => $"Your score: {correct} out of 3. Well done!",
                _ => $"Your score: {correct} out of 3"
            };
            Console.WriteLine(feedback);
        }
    }
}
