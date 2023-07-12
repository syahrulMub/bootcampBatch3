using System;

namespace MyEmployee;
class Program
{
    static void Main()
    {
        FullTime orang1 = new("Syahrul", 23, 98789);
        PartTime orang2= new("Surya", 25, 33231);
        Console.WriteLine($"Nama : {orang1.name}\nUmur : {orang1.age}\nNomor Pegawai : {orang1.employeeNumber}");
        orang1.GetSalary(3000000);
        orang1.GetTitle("CEO");
        Console.WriteLine($"Nama : {orang2.name}\nUmur : {orang2.age}\nNomor Pegawai : {orang2.employeeNumber}");
        orang2.GetSalary(20000);
        orang2.GetContract(2);
    }
}