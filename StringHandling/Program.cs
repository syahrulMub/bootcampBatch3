namespace Pelanggan;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan Nama Lengkap Anda : ");
        string name = Console.ReadLine();
        while (!name.Contains(" "))
        {
            Console.WriteLine("Nama Lengkap Harus Mengandung Spasi");
            Console.WriteLine("Masukkan nama lengkap Anda: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Masukkan nomor ID pelanggan: ");
        string idPelanggan = Console.ReadLine();

        Pelanggan pelanggan = new (name);
        string inisial = pelanggan.Initials();

        Console.WriteLine("Inisial Anda: " + inisial.ToUpper());
        Console.WriteLine("nomor ID anda : " + idPelanggan);

        if (idPelanggan.EndsWith("X"))
        {
            Console.WriteLine("Anda memenuhi syarat untuk diskon khusus!");
        }
    }
}
