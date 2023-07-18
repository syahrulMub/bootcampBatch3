using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> produk = new Dictionary<string, int>()
        {
            {"sabun" , 4000},
            {"sikat lantai", 6000},
            {"sikat gigi", 6000},
            {"detergen", 20000}
        };

        foreach (var item in produk)
        {
            Console.WriteLine($"Jenis Barang : {item.Key} Harga : {item.Value}");
        }
    }
}