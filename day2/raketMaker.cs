using System;
namespace RaketMaker;

public class Raket
{
    public string name;
    public int weight;
    public int tention;
    public Boolean available;
    
    public Raket(string name)
    {
        this.name = name;
    }

    public void Smash(int power, string position)
    {
        Console.WriteLine($"{name} Smash {power} with {position} shuttlekock");
    }
    public void DropShot(string confortable)
    {
        Console.WriteLine($"{name} Drop Shot {confortable}");
    }

}
