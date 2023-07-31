namespace MyProgram;
class Program
{
    static void Main(string[] args)
    {
        int saldo = 100;
        ShowSaldo(in saldo);
        PlusSaldo(ref saldo, 10);
        PlusSaldo(ref saldo, 200);
        MinusSaldo(ref saldo,20);
        PlusSaldo(ref saldo, 300);
        PlusSaldo(ref saldo, 500);
        int totalSaldo = TotalSaldo(saldo, out int SaldoAkhir);
        Console.WriteLine($"Total Saldo Anda : {totalSaldo}");
    }

    static void ShowSaldo(in int x)
    {
        Console.WriteLine(x);
    }
    static void PlusSaldo(ref int saldo, int SaldoMasuk)
    {
        saldo += SaldoMasuk;
    }
    static void MinusSaldo(ref int saldo, int SaldoMasuk)
    {
        saldo -= SaldoMasuk;
    }
    static int TotalSaldo(int saldo, out int SaldoAkhir)
    {
        SaldoAkhir = saldo;
        return saldo; 
    }
}