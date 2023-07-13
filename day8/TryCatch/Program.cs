namespace TryCatch;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Pecahan Pecahan1 = new Pecahan(9,4);
            Pecahan Pecahan2 = new Pecahan(3,8);
            Pecahan Pecahan3 = new Pecahan(3,8);
            Pecahan HasilJumlah = Pecahan1 + Pecahan2;
            HasilJumlah.Simplify();
            Pecahan HasilKurang = hasilJumlah - Pecahan3;
            HasilKurang.Simplify();
            Console.WriteLine($"hasil Penjumlahan : {HasilJumlah.pembilang}/{HasilJumlah.penyebut}");
            Console.WriteLine($"hasil Pengurangan : {HasilKurang.pembilang}/{HasilKurang.penyebut}");
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