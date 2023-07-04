using System;
namespace LaptopMaker;

public class Laptop
{
    //properti kelas
    private string _name;
    private int _price;
    private int _ram;

    public Laptop(string name, int price, int ram)
    {
        _name = name;
        if (price > 0)
        {
            _price = price;
        }
        else
        {
            _price = 0;
        }
        _ram = ram;
    }
    public string? GetName(string password)
    {
        if (password == "PASSWORD")
        {
            return _name;
        }
        else
        {
            return null;
        }
    }
    public bool SetName(string name)
    {
        if (_name != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int GetPrice()
    {
        return _price;
    }
    public int GetRam()
    {
        return _ram;
    }
}