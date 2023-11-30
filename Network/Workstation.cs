public class Workstation : Computer, IConnectable
{
    public Workstation(string ipAddress, int power, string operatingSystem)
        : base(ipAddress, power, operatingSystem)
    {
    }

    public void Connect(IConnectable device)
    {
        Console.WriteLine($"{IPAddress} connected to {((Computer)device).IPAddress}");
    }

    public void Disconnect(IConnectable device)
    {
        Console.WriteLine($"{IPAddress} disconnected from {((Computer)device).IPAddress}");
    }

    public void TransmitData(string data)
    {
        Console.WriteLine($"{IPAddress} transmitted data: {data}");
    }
}