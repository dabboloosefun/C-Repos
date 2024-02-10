namespace CodeGrade
{
    class SecondSpare
    {
        static void Main()
        {
            Console.WriteLine("How many seconds?");
            double Seconds = Convert.ToDouble(Console.ReadLine());
            double RemainingSeconds = (Seconds % 60);
            double Minutes = ((Seconds - RemainingSeconds) / 60);
            double RemainingMinutes = (Minutes % 60);
            double Hours = ((Minutes - RemainingMinutes) / 60);
            Console.WriteLine($"Hours: {Hours}");
            Console.WriteLine($"Minutes: {RemainingMinutes}");
            Console.WriteLine($"Seconds left: {RemainingSeconds}");
        }
    }
}