public class Vehicle : IDriveable
{
    private double speed;
    private double size;
    private string type;

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public double Size
    {
        get { return size; }
        set { size = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Vehicle(double speed, double size, string type)
    {
        Speed = speed;
        Size = size;
        Type = type;
    }

    public void Move()
    {
        Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} has stopped");
    }
}