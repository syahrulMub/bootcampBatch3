using System;
using TransferFootballer;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Transfer> Players = new List<Transfer>();
        Players.Add(new Transfer("Kante", 33, "France", 120, 90, 80, 71));
        Players.Add(new Transfer("Ronaldo", 34, "Portugal", 180, 97, 75, 80));
        Players.Add(new Transfer("Camavinga", 22, "france", 100, 87, 90, 88));
        Players.Add(new Transfer("Benzema", 35, "france", 110, 90, 77, 86));
        Players.Add(new Transfer("Belligham", 19, "england", 120, 92, 88, 84));

        foreach (var player in Players)
        {
            Console.WriteLine($"Nama : {player.name}\nUmur : {player.age}\nNegara : {player.nation}");
            player.GetAttack();
            player.GetDefense();
            player.GetStamina();
            Console.WriteLine($"apakah {player.name} layak untuk dibeli : {player.GoodToBuy()}");
            Console.WriteLine();
        }
    }
}