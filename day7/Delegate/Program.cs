public delegate void MyDelegate();

class Program
{
    public static void Main(string[] args)
    {
        MyDelegate Delegate = sayHello;
        Delegate();
        Delegate += sayHi;
        Delegate();
    }

    static void sayHello()
    {
        Console.WriteLine("Hello");
    }
    static void sayHi()
    {
        Console.WriteLine("Hi");
    }
}