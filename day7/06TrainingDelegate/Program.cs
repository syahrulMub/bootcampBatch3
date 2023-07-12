// using System;

// delegate void AnimalAction();
// class Animal {

//     AnimalAction EatAction = Eat;
//     AnimalAction SleepAction = Sleep;
//     AnimalAction PlayAction = Play;

//     public static void Eat() {
//         Console.WriteLine("\nEating");
//     }

//     public static void Sleep() {
//         Console.WriteLine("\nSleeping");
//     }

//     public static void Play() {
//         Console.WriteLine("\nPlaying");
//     }

//     public void PerformAction(AnimalAction a) {
//         a();
//     }

// }
static class Program
{
    delegate void AnimalAction(string nama);
    static void Main(string[] args)
    {
        AnimalAction EatAction = Eat; // object of delegate
        AnimalAction SleepAction = Sleep;
        AnimalAction PlayAction = Play;

        EatAction += Sleep;
        EatAction += Play;

        Console.WriteLine("welcome to Animal Action Simulation");
        Console.WriteLine(" \nChoose E for Eat, S for Sleep, P for Play ");
        char input = ' ';

        while (input != 'X')
        {
            input  = char.ToUpper(Console.ReadKey().KeyChar);
            switch (input)
            {
                case 'E':
                PerformAction(EatAction);
                break;
                case 'S':
                PerformAction(SleepAction); 
                break;
                case 'P':
                PerformAction(PlayAction);
                break;
            }
    }
        }
    static void Eat(string name)
    {
        Console.WriteLine($"\n{name} Eating");
    }
    static void Sleep(string name)
    {
        Console.WriteLine($"\n{name} Sleeping");
    }
    static void Play(string name)
    {
        Console.WriteLine($"\n{name} Playing");
    }
    static void PerformAction(AnimalAction a)
    {
        a("bebek");
    }
}

// using System;

// namespace OOP;

// class Animal {
//     public void EatAction() {
//         Console.WriteLine("\nEating");
//     }

//     public void SleepAction() {
//         Console.WriteLine("\nSleeping");
//     }

//     public void PlayAction() {
//         Console.WriteLine("\nPlaying");
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         Animal animal = new Animal();
//         // Animal animal2 = new Animal();
//         Console.WriteLine("welcome to Animal Action Simulation");
//         Console.WriteLine(" \nChoose E for Eat, S for Sleep, P for Play ");
//         char input = ' ';

//         while (input != 'X')
//         {
//             input  = char.ToUpper(Console.ReadKey().KeyChar);
//             switch (input)
//             {
//                 case 'E':
//                 animal.EatAction();
//                 animal.PlayAction();
//                 // animal2.EatAction();
//                 break;
//                 case 'S':
//                 animal.SleepAction();
//                 break;
//                 case 'P':
//                 animal.PlayAction();
//                 break;
//             }
//     }
//     }
// }