using System;
using TransferFootballer;

class Program
{
    static void Main()
    {
        Transfer player1 = new Transfer("Kante", 33, "France", 120);
        Console.WriteLine($"Name : {player1.name}\nAge : {player1.age}\nNation : {player1.nation}\n");
        
        player1.GetAttack(91);
        player1.GetDefense(71);
        player1.GetStamina(81);
        bool beliPlayer1kah = player1.GoodToBuy();
        Console.WriteLine($"{player1.name} is good to buy? {beliPlayer1kah}\n");

        Transfer player2 = new Transfer("Ronaldo", 34, "Portugal", 180);
        Console.WriteLine($"Name : {player2.name}\nAge : {player2.age}\nNation : {player2.nation}\n");
        player2.GetAttack(94);
        player2.GetDefense(75);
        player2.GetStamina(86);
        bool beliPlayer2kah = player2.GoodToBuy();
        Console.WriteLine($"{player2.name} is good to buy? {beliPlayer2kah}\n");

        Transfer player3 = new Transfer("Camavinga", 21, "France", 100);
        Console.WriteLine($"Name : {player3.name}\nAge : {player3.age}\nNation : {player3.nation}\n");
        player3.GetAttack(76);
        player3.GetDefense(92);
        player3.GetStamina(85);
        bool beliPlayer3kah = player3.GoodToBuy();
        Console.WriteLine($"{player3.name} is good to buy? {beliPlayer3kah}\n");
    }
}