using System.Collections;

public class Vektor2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vektor2D(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Vektor2D operator *(Vektor2D Vektor, int skala)
    {
        int newX = Vektor.X * skala;
        int newY = Vektor.Y * skala;
        return new Vektor2D(newX, newY);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vektor2D vektor1 = new Vektor2D(3, 2);
        int skala = 3;
        Vektor2D vektorResult = vektor1 * skala;
        Console.WriteLine($"Hasil Perkalian ({vektorResult.X},{vektorResult.Y})");
    }
}
