class LeapYear
{
    public static void Main()
    {
        PrintIsLeapYear(2024);
        PrintIsLeapYear(2000);
    }


    public static bool IsDivisibleBy(int intOne, int intTwo)
    {
        if (intOne % intTwo == 0) return true;
        return false;
    }


    public static bool IsLeapYear(int year)
    {
        if (IsDivisibleBy(year, 4))
        {
            if (IsDivisibleBy(year, 100))
            {
                if (IsDivisibleBy(year, 400)) return true;
                return false;
            }
            return true;
        }
        return false;
    }


    public static void PrintIsLeapYear(int year)
    {
        Console.WriteLine(IsLeapYear(year) ? $"{year} is a leap year" : $"{year} is not a leap year");
    }
}
