using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TrainingSQLite;

public class Northwind : DbContext
{
    private string path = String.Empty;
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connection = (path);
        options.UseSqlite(connection);
    }
}