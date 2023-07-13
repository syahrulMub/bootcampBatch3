using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Membuat objek Thread dan memberikan metode yang akan dijalankan di dalamnya
        Thread t1 = new Thread(CountNumbers);
        
        // Memulai thread
        t1.Start();
        
        // Melakukan tugas lain di thread utama
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Tugas lain: " + i);
            Thread.Sleep(500); // Memberikan jeda setengah detik
        }
        
        // Menunggu thread lain selesai
        t1.Join();
        
        Console.WriteLine("Selesai.");
    }
    
    static void CountNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread: " + i);
            Thread.Sleep(1000); // Memberikan jeda satu detik
        }
    }
}