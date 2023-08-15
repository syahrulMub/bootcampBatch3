using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TrainingSQLite;

public partial class Program
{
    public static void Main(string[] args)
    {
        Northwind db = new Northwind();
        Console.WriteLine($"Provider: {db.Database.ProviderName}");

    }
}