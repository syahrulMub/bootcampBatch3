using System;
namespace TrainingDelegate02;

//ini adalah contoh delegate yang dijalankan dalam sebuah fungsi
public delegate void WorkingHandler(string name);

class Program
{
    static void Main()
    {
        Program obj = new();
        WorkingHandler orang1 = new(obj.Working);
        GetEat(orang1);
    }

    public static void GetEat(WorkingHandler jeneng)
    {
        Console.WriteLine("method GetEat dijalankan");
        jeneng("syahrul");
    }
    public void Working(string nama)
    {
        Console.WriteLine("method working dipanggil");
        Console.WriteLine($"{nama} sedang belajar");
    }
}