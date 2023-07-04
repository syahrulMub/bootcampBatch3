using System;
using Footballer;

namespace MainProgram;
class Program
{
    static void Main()
    {
        Player Player = new Player("Benzema", 34, "Al Ittihad");
        string NamaPlayer = Player.GetName();
        int UmurPlayer = Player.GetUmur();
        string ClubPlayer = Player.GetClub();

        Console.WriteLine($"Nama : {NamaPlayer} \nUmur : {UmurPlayer} \nClub : {ClubPlayer}");
    }
}