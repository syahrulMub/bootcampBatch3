//contoh enum pada bulan

public class ExEnum
{
    public enum Bulan
    {
        Januari = 1,
        Februari,
        Maret,
        April,
        Mei,
        Juni,
        Juli,
        Agustus,
        September,
        Oktober,
        November,
        Desember
    }

    public static void Main()
        {
            //mengakses bulan
            Bulan bulanIni = Bulan.Juli;
            Console.WriteLine("sekarang adalah bulan " + bulanIni);

            switch(bulanIni)
            {
                case Bulan.Januari:
                Console.WriteLine("Ini Bulan Januari");
                break;
                case Bulan.Februari:
                Console.WriteLine("Ini Bulan Februari");
                break;
                case Bulan.Maret:
                Console.WriteLine("Ini Bulan Maret");
                break;
                case Bulan.April:
                Console.WriteLine("Ini Bulan April");
                break;
                case Bulan.Mei:
                Console.WriteLine("Ini Bulan Mei");
                break;
                case Bulan.Juni:
                Console.WriteLine("Ini Bulan Juni");
                break;
                case Bulan.Juli:
                Console.WriteLine("Ini Bulan Juli");
                break;
                case Bulan.Agustus:
                Console.WriteLine("Ini Bulan Agustus");
                break;
                case Bulan.September:
                Console.WriteLine("Ini Bulan September");
                break;
                case Bulan.Oktober:
                Console.WriteLine("Ini Bulan Oktober");
                break;
                case Bulan.November:
                Console.WriteLine("Ini Bulan November");
                break;
                case Bulan.Desember:
                Console.WriteLine(Bulan.Desember);
                break;
            }
        //mencetrak data dari enum
        foreach (var namaBulan in Enum.GetValues(typeof(Bulan)))
        {
            Console.WriteLine(namaBulan);
        }
        Console.WriteLine("============");
        Bulan bulanBesok = Bulan.Agustus;
        Console.WriteLine(bulanBesok);
        Console.WriteLine((int) bulanBesok);
    }
}