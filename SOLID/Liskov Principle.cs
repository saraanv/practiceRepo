//  SOLID Principles: L: Liskov

public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();
}
public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Starting The Car Enginge.");
    }
    public override void StopEngine()
    {
        Console.WriteLine("Stoping The Car Enginge.");
    }
}
public class ElectricalCar : Vehicle
{
    public override void StartEngine()
    {
        throw new InvalidOperationException("Electical Cars Do Not Have Engine");
    }
    public override void StopEngine()
    {
        throw new InvalidOperationException("Electical Cars Do Not Have Engine");
    }
}

// The Problem With Code Above Is That A Particular Child Like Electrical Cars Do Not Have Engine.
// So Using Engine Inside Of The Parent Class Like Vehicle Us Incorrect.

// Fixed:
public abstract class Vehicle
{
    
}

public interface IEnginePowered
{
    void StartEngine();
    void StopEngine();
}

public class Car : Vehicle, IEnginePowered 
{
    public void StartEngine()
    {
        Console.WriteLine("Starting The Car Engine.");
    }
    public void StopEngine()
    {
        Console.WriteLine("Stopping The Car Engine.");
    }
}

public class ElectricalCar : Vehicle
{

}