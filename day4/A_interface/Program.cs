
using A_interface;

class Program
{
    static void Main()
    {
        Door DoorBrand = new Door("Equadoor");
        Machine MachineBrand = new Machine("Oto");
        Tire TireBrand = new Tire("Dunlop");

        Car Inova = new Car("Inova",DoorBrand, MachineBrand, TireBrand);

        Console.WriteLine("Merek Mobil : " + Inova.nameCar.ToUpper());
        Console.WriteLine($"Merek Pintu mobil {Inova.nameCar}: {Inova.door.nameDoor}");
        Console.WriteLine($"Merek Mesin mobil {Inova.nameCar} : {Inova.machine.nameMachine}");
        Console.WriteLine($"Merek Ban mobil {Inova.nameCar} : {Inova.tire.nameTire}");
        Inova.door.Handler("auto Open");
    }
}