namespace A_interface;

public class Car
{
    public string nameCar;
    public Door door { get; set; }
    public Machine machine { get; set; }
    public Tire tire { get; set; }

    //constructior 
    public Car(string nameCar,Door door, Machine machine, Tire tire)
    {
        this.nameCar = nameCar;
        this.door = door;
        this.machine = machine;
        this.tire = tire;
    }
}