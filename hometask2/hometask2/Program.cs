using System;

public enum CarType
{
    Sport,
    SUV,
    Sedan
}


class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Mercedes", "Cls550", CarType.Sedan);
        Car car2 = new Car("BMW", "F10", CarType.Sedan);
        Car car3 = new Car("Volvo", "X90", CarType.SUV);

        Console.WriteLine(car1);
        Console.WriteLine(car2);
        Console.WriteLine(car3);
    }
}
