using System;
using LaptopMaker;
namespace MySystem;
public class Program
{
    static void Main()
    {
        Laptop Laptop = new Laptop("lenovo", 4000, 4);
        string? nameLaptop = Laptop.GetName("PASSWORD");
        bool namaLaptop = Laptop.SetName("Lenovo");
        if (namaLaptop)
        {
            Console.WriteLine("sesuai");
        }
        else
        {
            Console.WriteLine("tidak sesuai");
        }
        int Harga = Laptop.GetPrice();
        int ram = Laptop.GetRam();
        Console.WriteLine($"harga laptop {nameLaptop} {Harga} dengan ram {ram}");  

    }
}