namespace TryCatch;

public class Pecahan
{
    public int pembilang{ get; set; }
    public int penyebut { get; set; }

    public Pecahan(int pembilang, int penyebut)
    {
        this.pembilang = pembilang;
        this.penyebut = penyebut;
    }

    public static Pecahan operator +(Pecahan a, Pecahan b)
    {
        int newPembilang = (a.pembilang*b.penyebut) + (b.pembilang*a.penyebut);
        int newPenyebut = (a.penyebut*b.penyebut);
        return new Pecahan(newPembilang, newPenyebut);
    }
    public static Pecahan operator -(Pecahan a, Pecahan b)
    {
        int newPembilang = (a.pembilang*b.penyebut) - (b.pembilang*a.penyebut);
        int newPenyebut = (a.penyebut*b.penyebut);
        return new Pecahan(newPembilang, newPenyebut);
    }
    public static int FPB(int a, int b)
    {
        while (b != 0)
        {
        int temp = b;
        b = a % b;
        a = temp;
        }
        return a;
    }
    public void Simplify()
    {
        int fpb = FPB(pembilang, penyebut);
        pembilang /= fpb;
        penyebut /= fpb;
    }
}