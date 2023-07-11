using System;

static class Program
{
    delegate void AnimalAction();
    static void Main(string[] args)
    {
        AnimalAction EatAction = Eat;
        AnimalAction SleepAction = Sleep;
        AnimalAction PlayAction = Play;

        Console.WriteLine("welcome to Animal Simulation");
        Console.WriteLine(" \n Choose C for Cat, D for Dog, A for Ant ");
        char input = ' ';

        while (input != 'X')
        {
            input  = char.ToUpper(Console.ReadKey().KeyChar);
            switch (input)
            {
                case 'C':
                PerformAction = EatAction + " Cat";
                break;
                case 'D':
                PerformAction = EatAction + " Dog"; 
                break;
            }
        }
    }
}