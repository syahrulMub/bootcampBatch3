namespace TrainingEnum;
public enum Warna
{
    Merah,
    Buru,
    Hitam
}
public class Kendaraan
{
    public string merek;
    public int tahun { get; set; }
    public Warna warna { get; set; }

    public Kendaraan(string merek, int tahun, Warna warna)
    {
        this.merek = merek;
        this.tahun = tahun;
        this.warna = warna;
    }
}

public class Mobil : Kendaraan
{
    public int kapasitas { get; set; }
    public Mobil(string merek, int tahun, Warna warna, int kapasitas) : base(merek, tahun, warna)
    {
        this.kapasitas = kapasitas;
    }
    public void GetKapasitas()
    {
        Console.WriteLine($"Mobil{merek} memiliki {kapasitas} orang");
    }
}

public class Motor : Kendaraan
{
    public bool transmisi { get; set; }
    public Motor(string merek, int tahun, Warna warna, bool transmisi) : base(merek, tahun, warna)
    {
        this.transmisi = transmisi;
    }
    public void GetTransmisi()
    {
        string jenisTransmisi = this.transmisi ? "Manual" : "Matic";
        Console.WriteLine($"Motor Jenis {merek} Memilki jenis transmisi {jenisTransmisi}");
    }
}
