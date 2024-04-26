using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of FlyingCar and DrivingCar
        FlyingCar flyingCar = new FlyingCar();
        DrivingCar drivingCar = new DrivingCar();

        // Demonstrate driving and flying functionalities
        Console.WriteLine("Flying Car:");
        flyingCar.Drive();
        Console.WriteLine();
        flyingCar.Fly();
        Console.WriteLine();

        Console.WriteLine("\nDriving Car:");
        drivingCar.Drive();
        Console.WriteLine();

        Console.ReadLine();
    }
}
