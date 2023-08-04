using System;
namespace TransferFootballer;
class Transfer
{
    //propertien
    public string name { get; set; }
    public int age { get; set; }
    public string nation { get; set; }
    public int cost { get; set; }

    //construction
    public Transfer(string name, int age, string nation, int cost)
    {
        this.name = name;
        this.age = age;
        this.nation = nation;
        this.cost = cost;
    }

    public void GetAttack(int skor)
    {
        string level;
        //kondisi
        if (skor <= 100 & skor >= 80)
        {
        level = "high";
        }
        else if ( skor < 80 & skor > 60)
        {
        level = "good";
        }
        else if ( skor < 60 & skor > 40)
        {
        level = "enough";
        }
        else if ( skor < 40 & skor > 20)
        {
        level = "less";
        }
        else 
        level = "unknow";
        Console.WriteLine($"{name} have {level} attack with power : {skor}");
    }
    public void GetDefense(int skor)
    {
        string level;
        //kondisi
        if (skor <= 100 & skor >= 80)
        {
        level = "high";
        }
        else if ( skor < 80 & skor > 60)
        {
        level = "good";
        }
        else if ( skor < 60 & skor > 40)
        {
        level = "enough";
        }
        else if ( skor < 40 & skor > 20)
        {
        level = "less";
        }
        else 
        level = "unknown";
        Console.WriteLine($"{name} have {level} defense with power : {skor}");   
    }
    public void GetStamina(int skor)
    {
        string level;
        //kondisi
        if (skor <= 100 & skor >= 80)
        {
        level = "high";
        }
        else if ( skor < 80 & skor > 60)
        {
        level = "good";
        }
        else if ( skor < 60 & skor > 40)
        {
        level = "enough";
        }
        else if ( skor < 40 & skor > 20)
        {
        level = "less";
        }
        else 
        level = "unknow";
        Console.WriteLine($"{name} have {level} stamina with power : {skor}");
    }

    //fungsi untuk apakah mau mentransfer pemain
    public bool GoodToBuy()
    {
        return (cost * age <= 2400);
    }
}