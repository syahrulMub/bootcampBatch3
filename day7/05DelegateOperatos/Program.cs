public delegate int Operator(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        Operator operasi = Add;
        operasi += Product;
        Console.WriteLine(operasi(1, 2));

    }
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Product(int a, int b)
    {
        return a * b;
    }
}
