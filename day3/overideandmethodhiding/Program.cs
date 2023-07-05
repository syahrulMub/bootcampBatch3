class Program
{
    static void Main(string[] args)
        {
        // Parent objA = new Parent("Pak Kasmin");
        FirstChild objB = new FirstChild("Surya");
        SecondChild objC = new SecondChild("Paijo");
        thirdChild objD = new thirdChild("Paimin");

        // Console.WriteLine(objA.name);
        Console.WriteLine(objB.name);
        // Console.WriteLine(objA.Kalimat());
        Console.WriteLine(objB.Kalimat());
        objB.HarusBelajar();
        objB.Olahraga();
        
        Console.WriteLine(objC.name);
        Console.WriteLine(objC.Kalimat());
        objC.HarusBelajar();

        Console.WriteLine(objD.name);
        objD.HarusBelajar();
        objD.Olahraga();
        }
}

public interface IOlahraga
{
    void Olahraga();
}
abstract class Parent   
{
    public string? name;
    abstract public void HarusBelajar();

    public Parent(string name)
    {
        Console.WriteLine("parent constructor called name : " + name);
        this.name = name;
    }
    public virtual string Kalimat()
    {
        return ("pesan saya 'jadi anak yang baik'");
    }
}

class FirstChild : Parent , IOlahraga
{
    public FirstChild(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
    }

    public override void HarusBelajar()
    {
        Console.WriteLine("saya belajar agama");
    }

    //tidak bisa menambahkan fungsi yang tidak ada dalam orang tuanya
    public override string Kalimat()
    {
        return ("kata bapak saya 'jadi anak yang baik'");
    }

    public void Olahraga()
    {
        Console.WriteLine("saya suka Olahraga sepak bola");
    }
}

class SecondChild : Parent
{
    public SecondChild(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
        this.name = name;
    }

    public override void HarusBelajar()
    {
        Console.WriteLine("Saya belajar Programming Language");
    }

    public override string Kalimat()
    {
        return ("emang apa kata bapak?");
    }
}

class thirdChild : Parent, IOlahraga
{
    public thirdChild(string name) : base(name)
    {
        Console.WriteLine("child constructior callad name : " + name);
        this.name = name;
    }
    public override void HarusBelajar()
    {
        Console.WriteLine("saya belajar Matematika");
    }

    public void Olahraga()
    {
        Console.WriteLine("Saya suka Olahraga Bulutangkis");
    }
}