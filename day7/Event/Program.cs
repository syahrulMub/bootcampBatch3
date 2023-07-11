public delegate void MyDelegate();

class Program
{
    public static void Main(string[] args)
    {
        MyDelegate Delegate = sayHello;
        Delegate();
    }

    static void sayHello()
    {
        Console.WriteLine("Hello");
    }
}