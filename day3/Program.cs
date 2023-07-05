public interface Iprint
{
    void print();
}
public interface IScan
{
    void scan();
}


public class printer500rubu : Iprint
{
    public void print()
    {
        Console.WriteLine("printer 500ribu bisa melakukan print");
    }
}
// bisa dilakukan karena multiple inheritance
public class printer1Juta : Iprint, IScan
{
    public void print()
    {
        Console.WriteLine("printer 1Juta bisa melakukan print");
    }
    public void scan()
    {
        Console.WriteLine("printer 1Juta bisa melakukan scan");
    }
}
