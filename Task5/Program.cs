public abstract class Vehicle
{
    public abstract void Move();
    public virtual void Stop()
    {
        Console.WriteLine("Vehicle is stopping");
    }
}

public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving");
    }

    public override void Stop()
    {
        Console.WriteLine("Car is stopping by applying brakes");
    }
}
public class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }

    public override void Stop()
    {
        Console.WriteLine("Bicycle is stopping by applying pedals");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle myCar = new Car();
        myCar.Move();
        myCar.Stop();

        Vehicle myBicycle = new Bicycle();
        myBicycle.Move();
        myBicycle.Stop();
    }
}