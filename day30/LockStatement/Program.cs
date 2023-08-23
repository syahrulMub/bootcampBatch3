using System.Threading;
using System.Threading.Tasks;

static class Program
{
    static double value = 1;
    static object CounterLock = new object();
    static async Task Main(string[] args)
    {
        var task1 = Task.Run(() => ProgramPerkalian());
        var task2 = Task.Run(() => ProgramPembagian());

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Task Completed");
    }
    static async Task ProgramPerkalian()
    {
        for (int i = 1; i < 10; i++)
        {
            lock (CounterLock)
            {
                value *= i;
                Console.WriteLine($"perkalian {i} dengan hasil {value}");
            }
            await Task.Delay(1000);
        }
    }
    static async Task ProgramPembagian()
    {
        for (int i = 1; i < 10; i++)
        {
            lock (CounterLock)
            {
                value /= i;
                Console.WriteLine($"pembagian {i} dengan hasil {value}");
            }
            await Task.Delay(1000);
        }
    }

}