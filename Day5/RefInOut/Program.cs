namespace ClassRefInOut;
public class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2;
        int number3;
        FillNumber(out number3);
        int number4 = 15;

        MultipleandAddbyFour(ref number1,out number2);

        Console.WriteLine("nilai perkalian = " + number1);
        Console.WriteLine("nilai variabel out = " + number2);
        Console.WriteLine("nilai variabel out = " + number3);
        Kuadrat(in number4);
    }

    static void MultipleandAddbyFour(ref int x,out int y)
    {
        y = 4;
        x = x * 4;
    }
    static void FillNumber(out int number3)
    {
        number3 = 17;
    }
    static void Kuadrat(in int x)
    {
        Console.WriteLine(x * x);
    }
}