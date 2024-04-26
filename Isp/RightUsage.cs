using System;
public interface IDrive
{
    void Drive();
}
public interface IFly
{
    void Fly();
}

public class FlyingCar : IDrive, IFly
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

public class DrivingCar : IDrive
{
    public void Drive()
    {
        Console.Write("Driving Car");
    }

}