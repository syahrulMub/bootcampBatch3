namespace A_interface;

public class Tire : ITire
{
    public string nameTire;
    public Tire(string nameTire)
    {
        this.nameTire = nameTire;
    }

    public void Circle()
    {
        Console.WriteLine("Circle with range 14");
    }

    public void rotate()
    {
        Console.WriteLine("rotated with perfect circle");
    }
}
