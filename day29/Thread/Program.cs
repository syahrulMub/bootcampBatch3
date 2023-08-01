using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        
        // Thread Thread1 = new Thread(Repeat.RepeatOne);
        // Thread Thread2 = new Thread(Repeat.RepeatTwo);
        // Thread1.Start();
        // Thread2.Start();

        // Thread1.Join();
        // Thread2.Join();

        Repeat.RepeatOne();
        Repeat.RepeatTwo();
        
        timer.Stop();
        Console.WriteLine($"elapsed time: {timer.ElapsedMilliseconds} ms");

    }
}

public class Repeat
{
    public static void RepeatOne()
    {
        Console.WriteLine("Method repeat One is starting");
        string text = "DotNet";
        for ( int i = 0 ; i < 50000 ; i++ )
        {
            text += i + " ";
        }
        Console.WriteLine("TaskOne is Complete");
    }

    public static void RepeatTwo()
    {
        Console.WriteLine("Method repeat Two is starting");
        string text = "C#";
        for ( int i = 0 ; i < 50000 ; i++ )
        {
            text += i + " ";
        }
        Console.WriteLine("TaskTwo Is Complete");
    }
}