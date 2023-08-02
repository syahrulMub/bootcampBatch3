using System.Threading.Tasks;

class Program
{
    private static AutoResetEvent resetEvent = new AutoResetEvent(false);
    static async Task Main()
    {
        Console.WriteLine("PROGRAM STARTED");
        Task Referee = Task.Run(() => RefereeCount());
        Task CarF1 = Task.Run(async() =>
        {
            Console.WriteLine("F1 start machine");
            Console.WriteLine("Waiting for Referee");
            await Task.Run(() => resetEvent.WaitOne());
            Console.WriteLine("CarF1 move!!!");
        });
        Task CarF2 = Task.Run(async() =>
        {
            Console.WriteLine("F2 start machine");
            Console.WriteLine("Waiting for Referee");
            await Task.Run(() => resetEvent.WaitOne());
            Console.WriteLine("CarF2 move!!!");
        });
        Task CarF3 = Task.Run(async() =>
        {
            Console.WriteLine("F3 start machine");
            Console.WriteLine("Waiting for Referee");
            await Task.Run(() => resetEvent.WaitOne());
            Console.WriteLine("CarF3 move!!!");
        });

        await Task.WhenAll(CarF1, CarF2, CarF3);
        Console.WriteLine("ALL CAR MOVE");
    }
    static async Task RefereeCount()
    {
        for (int i = 3; i > 0 ; i--)
        {
            Console.WriteLine("Start in " + i);
            await Task.Delay(2000);
        } 
        Console.WriteLine("!!!GOOO!!!");
        resetEvent.Set();
    }
}