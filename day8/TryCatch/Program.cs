namespace TryCatch;
class Program
{
    static void Main(string[] args)
    {
        Pecahan pecahan1 = new Pecahan(9,4);
        Pecahan pecahan2 = new Pecahan(3,9);
        Pecahan pecahan3 = new Pecahan(3,0);
        try
        {
            if (pecahan1.penyebut == 0 || pecahan2.penyebut == 0 || pecahan3.penyebut == 0)
            {
                throw new DivideByZeroException("Penyebut 0 tidak dapat di Operasikan");
            }
            else 
            {
            Pecahan hasilJumlah = pecahan1 + pecahan2;
            hasilJumlah.Simplify();
            Pecahan hasilKurang = hasilJumlah - pecahan3;
            hasilKurang.Simplify();
            Console.WriteLine($"hasil Penjumlahan : {hasilJumlah.pembilang}/{hasilJumlah.penyebut}");
            Console.WriteLine($"hasil Pengurangan : {hasilKurang.pembilang}/{hasilKurang.penyebut}");
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Pesan {e.Message}");
        }
        finally
        {
            Console.WriteLine("Warning !!! Pecahan dengan pembagi 0 tidak dapat dioperasikan");
        }
    }
}