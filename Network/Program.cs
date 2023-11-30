using System;

class Program
{
    public static void Main()
    {
        Server server = new Server("192.168.1.1", 1000, "Windows Server");
        Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
        Router router = new Router("192.168.1.3", 800, "RouterOS");

        Network network = new Network();

        network.EstablishConnection(server, workstation);
        network.TransmitData(server, workstation, "Hello, workstation!");

        network.EstablishConnection(router, workstation);
        network.TransmitData(router, workstation, "Routing data!");

        network.DisconnectDevices(server, workstation);
        network.DisconnectDevices(router, workstation);
    }
}
