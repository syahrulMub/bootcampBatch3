using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task<double> task = Task.Run(() => Pangkat(3));
        double result = task.Result;
        Console.WriteLine($"Result is {result}");
    }

    public static double Pangkat(double angka)
    {
        return Math.Pow(5, angka);
    } 
}