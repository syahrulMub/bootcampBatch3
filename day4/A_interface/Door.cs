namespace A_interface;

public class Door : IDoor
{
    public string nameDoor;
    public Door(string nameDoor)
    {
        this.nameDoor = nameDoor;
    }

    public void Handler(string methode)
    {
        Console.WriteLine("Hadnler can open with " + methode);
    }

    public void Lock()
    {
        Console.WriteLine("Locked savety with double lock");
    }
}
