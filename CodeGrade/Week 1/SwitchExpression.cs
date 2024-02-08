namespace CodeGrade
{
    class SwitchExpression
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int Age = Convert.ToInt32(Console.ReadLine());
            string Category = Age switch
            {
                >= 0 and <= 12 => "a child",
                >= 13 and <= 19 => "a teenager",
                >= 20 and <= 150 => "an adult",
                _ => "invalid"
            }
            Console.WriteLine($"Age: {Age}: {Category}");
        }
    }
}