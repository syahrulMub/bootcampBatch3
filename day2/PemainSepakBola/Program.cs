using System;
using Footballer;

namespace MainProgram;
class Program
{
    static void Main()
    {
        List<Player> Players = new List<Player>();
        Players.Add(new Player("Benzema", 34, "Al Ittihad"));
        Players.Add(new Player("Camavinga", 22, "Real Madrid"));
        Players.Add(new Player("Phil Foden", 23, "Man City"));
        
        foreach (Player player in Players)
        {
        string NamaPlayer = player.GetName();
        int UmurPlayer = player.GetUmur();
        string ClubPlayer = player.GetClub();
        Console.WriteLine($"Nama : {NamaPlayer} \nUmur : {UmurPlayer} \nClub : {ClubPlayer}\n");
        }
    }
}