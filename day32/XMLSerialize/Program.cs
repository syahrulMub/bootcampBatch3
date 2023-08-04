using System.XML.Serialization;

public class Car
{
    public int series { get; set; }
    public string name { get; set; }
    public Car(int series, string name)
    {
        this.series = series;
        this.name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}