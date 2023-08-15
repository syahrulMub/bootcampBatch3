namespace TrainingSQLite;

public partial class Program
{
    static void Fail(string message)
    {
        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Fail > {message}");
        Console.ForegroundColor = previousColor;
    }
}
