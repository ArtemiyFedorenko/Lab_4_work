public class Computer
{
    private string iPAddress;
    private int power;
    private string operatingSystem;

    public string IPAddress
    {
        get { return iPAddress; }
        set { iPAddress = value; }
    }
    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    public string OperatingSystem
    {
        get { return operatingSystem; }
        set { operatingSystem = value; }
    }

    public Computer(string ipAddress, int power, string operatingSystem)
    {
        IPAddress = ipAddress;
        Power = power;
        OperatingSystem = operatingSystem;
    }
}