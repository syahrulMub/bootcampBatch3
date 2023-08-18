using System.Linq;

using var db = new Example();

Console.WriteLine($"data base path : {db.DbPath}");

Console.WriteLine("add data");
db.Add(new User { name = "ardi", email = "ard.ajnas.com" });
db.SaveChanges();

// Console.WriteLine("read data first id");
var data = db.users
            .OrderBy(x => x.userId)
            .First();

var read2 = db.users
            .OrderBy(x => x.name != "Ka")
            .First();
Console.WriteLine(data.name);

// data.name = "ardliyan kholifatul";
// db.SaveChanges();
Console.WriteLine(data.name);

// db.Remove(data);
// db.SaveChanges();