#define MOBIL
using TrainingEnum;
class Program
{
    static void Main(string[] args)
    {   
        #if (MOBIL)
        Mobil mobil1 = new Mobil("Kijang Kapsul", 2002, Warna.Hitam, 10);
        Console.WriteLine($"Merek : {mobil1.merek}\nTahun dibuat : {mobil1.tahun}\nWarnat : {mobil1.warna}\n");
        mobil1.GetKapasitas();
        #elif (MOTOR)
        Motor motor1 = new Motor("Supra X", 2005, Warna.Merah, true);
        Console.WriteLine($"Merek : {motor1.merek}\nTahun dibuat : {motor1.tahun}\nWarnat : {motor1.warna}\n");
        motor1.GetTransmisi();
        #else
        Console.WriteLine("no tipe in here");
        #endif
        Console.WriteLine("success debugging");
    }
}
