namespace _01Collection;
using System.Collections.Generic;
public class Book
{
    public string title { get; set; }
    private string? _author;
    public int datePublish { get; set; }
    public string? author
    {
        get { return _author; }
        set { _author = value; }
    }

    public Book(string title, string author, int datePublish)
    {
        this.title = title;
        this.author = author;
        this.datePublish = datePublish;
    }

    public virtual void Synopsis(string synopsis)
    {
        Console.WriteLine("Synopsis)");
        Console.WriteLine($"Buku {title} Menceritakan tentang :");
    }
}

class SelfDevelopment : Book
{
    public string language;

    public SelfDevelopment(string title, string author, int datePublish, string language) : base(title, author, datePublish)
    {
        this.language = language;
    }
    public override void Synopsis(string synopsis)
    {
        base.Synopsis(synopsis);
        Console.WriteLine(synopsis);
    }
}

class Roman : Book
{
    public int jilid;
    public Roman(string title, string author, int datePublish, int jilid) : base(title, author, datePublish)
    {
        this.jilid = jilid;
    }
    public override void Synopsis(string synopsis)
    {
        base.Synopsis(synopsis);
        Console.WriteLine(synopsis);
    }
}

class Kitab : Book
{
    public string tema;
    public Kitab(string title, string author, int datePublish, string tema) : base(title, author, datePublish)
    {
        this.tema = tema;
    }
    public override void Synopsis(string synopsis)
    {
        base.Synopsis(synopsis);
        Console.WriteLine(synopsis);
    }

}