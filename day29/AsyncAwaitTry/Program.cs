using System.Threading.Tasks;
using System.Collections.Generic;


class Program
{
    static async Task Main()
    {
        Task task1 = Task.Run(() => Console.WriteLine("Hello"));
        Task task2 = Task.Run(() => Console.WriteLine("World!"));
        
        await Task.WhenAll(task1, task2);
        Console.WriteLine("Task Completed");
        Task task3 = Task.Run(() => Console.WriteLine("Hello Too From Task3: "));

        int x = 7;
        int y = 20;
        Task<int> resultPerkalian = Task.Run(() => Perkalian(x,y));
        Task<int> resultPenjumlahan = Task.Run(() => Penjumlahan(x,y));

        Task firstTask = await Task.WhenAny(resultPerkalian, resultPenjumlahan);

        Console.WriteLine($"First Out is {firstTask == resultPerkalian}");


    }
    static int Perkalian(int x, int y)
    {
        return x*y;
    }
    static int Penjumlahan(int x, int y)
    {
        return x + y;
    }

}