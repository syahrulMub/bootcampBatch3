namespace TryCatch;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Pecahan pecahan1 = new Pecahan(9,4);
            Pecahan pecahan2 = new Pecahan(3,8);
            Pecahan pecahan3 = new Pecahan(3,8);
            Pecahan hasilJumlah = pecahan1 + pecahan2;
            hasilJumlah.Simplify();
            Pecahan hasilKurang = hasilJumlah - pecahan3;
            hasilKurang.Simplify();
            Console.WriteLine($"hasil Penjumlahan : {hasilJumlah.pembilang}/{hasilJumlah.penyebut}");
            Console.WriteLine($"hasil Pengurangan : {hasilKurang.pembilang}/{hasilKurang.penyebut}");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Pesan {e.Message}");
        }
        finally
        {
            Console.WriteLine("Pecahan dengan pembagi 0 tidak dapat dioperasikan");
        }
    }
}