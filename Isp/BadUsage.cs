using System;
public interface IVehicle
{
    void Drive();
    void Fly();
}

public class FlyingCarBad : IVehicle
{
    public void Drive()
    {
        Console.Write("Driving Car");
    }
    public void Fly()
    {
        Console.Write("Flying car");
    }
}

public class DrivingCarBad : IVehicle
{
    public void Drive()
    {
        Console.Write("Driving Car");
    }
    public void Fly()
    {
        throw new NotImplementedException();
    }
}