List<string> colors = new List<string> {"red", "yellow", "green", "blue"};
string chosenColor;
do
{
    Console.WriteLine("Pick a color (red/blue/green/yellow):");
    chosenColor = Console.ReadLine();
} while (!colors.Contains(chosenColor));

int chosenNumber;
do
{
    Console.WriteLine("Pick a number (1-8):");
    chosenNumber = Convert.ToInt32(Console.ReadLine());
} while (chosenNumber <= 0 || chosenNumber > 8);
int fortuneNumber = ((chosenColor.Length + chosenNumber) % 4 ) + 1;

// ^ Your code goes above ^
//No need to look below here for this assignment. But you are welcome to!
PrintFortune(fortuneNumber);

static void PrintFortune(int fortuneNumber)
{
    string fortune = fortuneNumber switch
    {
        1 => "You will be loved and be happy!",
        2 => "You will be loved and be rich!",
        3 => "You will be loved and be famous!",
        4 => "You will be loved, and you'll be happy, rich and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
    Console.WriteLine(fortune);
}
