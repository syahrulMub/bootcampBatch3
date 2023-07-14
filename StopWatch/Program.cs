using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
     Stopwatch timer1 = new Stopwatch();
    Stopwatch timer2 = new Stopwatch();
     timer1.Start();
     timer2.Start();
    string hasil = " ";
     for ( int i = 0; i < 1000; i++)
     {
        hasil += i;
     }
     Console.WriteLine(hasil);

     timer1.Stop();
     Console.WriteLine(timer1.Elapsed);

     StringBuilder sb = new StringBuilder();
     for ( int i = 0; i < 1000; i++)
     {
        sb.Append(i);
     }
     timer2.Stop();
     Console.WriteLine(timer2.Elapsed);
    }

}