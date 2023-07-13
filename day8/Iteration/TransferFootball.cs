using System;
namespace TransferFootballer;
class Transfer
{
    //propertien
    public string name;
    public int age;
    public string nation;
    public int cost;
    public int attack;
    public int defence;
    public int stamina;

    //construction
    public Transfer(string name, int age, string nation, int cost, int attack, int defence, int stamina)
    {
        this.name = name;
        this.age = age;
        this.nation = nation;
        this.cost = cost;
        this.attack = attack;
        this.defence = defence;
        this.stamina = stamina;
    }

    public void GetAttack()
    {
        string level;
        //kondisi
        if (attack <= 100 & attack >= 80)
        {
        level = "high";
        }
        else if ( attack < 80 & attack > 60)
        {
        level = "good";
        }
        else if ( attack < 60 & attack > 40)
        {
        level = "enough";
        }
        else if ( attack < 40 & attack > 20)
        {
        level = "less";
        }
        else 
        level = "unknow";
        Console.WriteLine($"{name} have {level} attack with power : {attack}");
    }
    public void GetDefense()
    {
        string level;
        //kondisi
        if (defence <= 100 & defence >= 80)
        {
        level = "high";
        }
        else if ( defence < 80 & defence > 60)
        {
        level = "good";
        }
        else if ( defence < 60 & defence > 40)
        {
        level = "enough";
        }
        else if ( defence < 40 & defence > 20)
        {
        level = "less";
        }
        else 
        level = "unknown";
        Console.WriteLine($"{name} have {level} defense with power : {defence}");   
    }
    public void GetStamina()
    {
        string level;
        //kondisi
        if (stamina <= 100 & stamina >= 80)
        {
        level = "high";
        }
        else if ( stamina < 80 & stamina > 60)
        {
        level = "good";
        }
        else if ( stamina < 60 & stamina > 40)
        {
        level = "enough";
        }
        else if ( stamina < 40 & stamina > 20)
        {
        level = "less";
        }
        else 
        level = "unknow";
        Console.WriteLine($"{name} have {level} stamina with power : {stamina}");
    }

    //fungsi untuk apakah mau mentransfer pemain
    public bool GoodToBuy()
    {
        if (cost * age <= 2400)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}