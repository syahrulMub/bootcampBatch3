namespace MoneyManagement;

public class ManageMoney
{
    
    public DateTime tanggal;
    public bool kategori;
    public int jumlah;
    public string keterangan;

    public ManageMoney(DateTime tanggal, bool kategori, int jumlah, string keterangan)
    {
        this.tanggal = tanggal;
        this.kategori = kategori;
        this.jumlah = jumlah;
        this.keterangan = keterangan;
    }
    public void GetInfo()
    {
        Console.WriteLine("Iformasi Keuangan saat ini");
        Console.WriteLine($"Tangal transaksi = {tanggal.ToString()}");
        Console.WriteLine($"Kategori transaksi = {kategori}");
        Console.WriteLine($"Jumlah transaksi = {jumlah}");
        Console.WriteLine($"Keterangan = {keterangan}");
    }
    public static int GetPemasukan(List<ManageMoney> daftar)
    {
        int totalMasuk = 0;
        foreach (var item in daftar)
        {
            if (item.kategori == true)
                {
                    totalMasuk += item.jumlah;
                }
        }
        return totalMasuk;
    }
    public static int GetPengeluaran(List<ManageMoney> daftar)
        {
            int totalKeluar = 0;
            foreach ( var item in daftar)
            {
                if (item.kategori == false)
                    {
                        totalKeluar += item.jumlah;
                    }
            }
            return totalKeluar;
        }
}
