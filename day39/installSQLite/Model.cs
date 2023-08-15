using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

public class Example : DbContext
{
    public string DbPath { get; set; }
    public DbSet<User> users { get; set; }

    public Example()
    {
        DbPath = Path.Combine(Environment.CurrentDirectory, "ex1.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite($"Data Source = {DbPath}");
    }
}

public class User
{
    public int userId { get; set; }
    public string name { get; set; }
    public string email { get; set; }
}