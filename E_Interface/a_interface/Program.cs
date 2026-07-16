namespace a_interface;


interface IVehicle
{
    public void accelerate();
}

class Aeroplane: IVehicle
{
    public void accelerate()
    {
        Console.WriteLine("Plane files.");
    }
}
class Car: IVehicle
{
    public void accelerate()
    {
        Console.WriteLine("Car Runs.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Aeroplane Boeing747 = new Aeroplane();
        Car BugatiVern =  new Car();
        Boeing747.accelerate();
        BugatiVern.accelerate();

        Console.WriteLine("OK done");
    }
}
