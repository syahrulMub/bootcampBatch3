namespace A_interface;

public class Machine : IMachine
{
    public string nameMachine;
    public Machine(string nameMachine)
    {
        this.nameMachine = nameMachine;
    }

    public void Fuel()
    {
        Console.WriteLine("bahan bakar menggunakan bensin");
    }

    public void SyetemOn()
    {
        Console.WriteLine("System dapat dinyalakan");
    }
}
