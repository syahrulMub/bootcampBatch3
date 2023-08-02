using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task task1 = null;
        Task task2 = null;
        Console.WriteLine("Main Method Started");
        task1 = Task.Run( async() =>
        {
            Console.WriteLine("Task1 started");
            Console.WriteLine("Task1 waiting for task2");
            await task2;
        });

        task2 = Task.Run( async() =>
        {
            Console.WriteLine("Task2 started");
            Console.WriteLine("Task2 waiting for task1");
            await task1;
        });

        await Task.WhenAll(task1, task2);
        Console.WriteLine("Task All Completed");
    }
}