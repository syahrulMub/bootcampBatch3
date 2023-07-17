using MoneyManagement;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<ManageMoney> myMoney = new ();
        myMoney.Add(new ManageMoney(new DateTime(2023-10-13),true, 100000, "Masuk dari orang tua"));
        myMoney.Add(new ManageMoney(new DateTime(2023-10-14),false, 50000, "Badminton"));
        myMoney.Add(new ManageMoney(new DateTime(2023-10-14),true  , 80000, "Teman bayar Utang"));
        myMoney.Add(new ManageMoney(new DateTime(2023-10-16),true  , 150000, "Kerja"));
        myMoney.Add(new ManageMoney(new DateTime(2023-10-20),false , 180000, "jalan-jalan Healing"));

        foreach (var transaksi in myMoney)
        {
            transaksi.GetInfo();
        }
        
        int totalMasuk = ManageMoney.GetPemasukan(myMoney);
        int totalKeluar = ManageMoney.GetPengeluaran(myMoney);
        Console.WriteLine($"Pemasukan anda : {totalMasuk}");
        Console.WriteLine($"Pengeluaran anda : {totalKeluar}");
        Console.WriteLine($"Selisih pemasukan dan pengeluaran anda : {totalMasuk - totalKeluar}");
    }
}