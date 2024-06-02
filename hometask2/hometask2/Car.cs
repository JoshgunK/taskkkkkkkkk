public class Car
{
    private static int _idCounter = 1;

    public int Id { get; }
    public string Brand { get; }
    public string Model { get; }
    public CarType Type { get; }

    public Car(string brand, string model, CarType type)
    {
        Id = _idCounter++;
        Brand = brand;
        Model = model;
        Type = type;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Brand: {Brand}, Model: {Model}, Type: {Type}";
    }
}