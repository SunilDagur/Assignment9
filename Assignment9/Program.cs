using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public class Car : Vehicle
{
    public string Make { get; }
    public string Model { get; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public void Drive()
    {
        Console.WriteLine($"Driving the {Make} {Model}.");
    }
}

// Sealing the Car class prevents further inheritance
public sealed class SealedCar : Car
{
    public SealedCar(string make, string model) : base(make, model)
    {
    }
}

/* Uncommenting this code will result in an error:
public class SubCar : SealedCar
{
    public SubCar(string make, string model) : base(make, model)
    {
    }
}
*/

public class Program
{
    public static void Main()
    {
        Vehicle vehicle = new Vehicle();
        Car car = new Car("Toyota", "Camry");
        SealedCar sealedCar = new SealedCar("Honda", "Accord");

        // Using methods
        vehicle.StartEngine();
        vehicle.StopEngine();

        car.StartEngine();
        car.Drive();
        car.StopEngine();

        sealedCar.StartEngine();
        sealedCar.Drive();
        sealedCar.StopEngine();
    }
}
