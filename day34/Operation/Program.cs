namespace Calculation;
class Program
{
    public static void Main(string[] args)
    {
        MyOperation op = new();


    }
}
public class MyOperation
{
    private int x;
    private int y;

    public int Add()
    {
        return x + y;
    }
    public int Sub()
    {
        return x - y;
    }
}