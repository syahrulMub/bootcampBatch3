using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Stream.WriteText();
        Stream.ReadText();
    }
}

public static class Stream
{
    public static void WriteText()
    {
        using (StreamWriter myStream = new StreamWriter("Output.txt", append : true))
        {
            for (int i = 0; i < 11 ; i++)
            {
                myStream.WriteLine("This is How I Learn output without give more beban");
            }
        } 
    }

    public static void ReadText()
    {
        using (StreamReader reader = new StreamReader("Output.txt"))
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
    }
}
