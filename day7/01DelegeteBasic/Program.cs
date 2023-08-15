using System;
namespace MyDelegate;

//ini adalah conoth delegate yang dimana method pencatat akan menerima jenis data dari delegate
public delegate void JalurDelegasi(int hour, WorkType activity);

class Program
{
    static void Main()
    {
        JalurDelegasi orang1 = new(GetCatatan);
        orang1(8, WorkType.belajar);

    }
    public static void GetCatatan(int jam, WorkType kegiatan)
    {
        Console.WriteLine("ini adalah catatan yang diterima dari jalur delegasi");
        Console.WriteLine($"Kegitan : {kegiatan}\nLama Kegiatan : {jam} jam");
    }

}
public enum WorkType
{
    belajar,
    bermainGame,
    istirahat
}