public class Network
{
    public void EstablishConnection(IConnectable device1, IConnectable device2)
    {
        device1.Connect(device2);
        device2.Connect(device1);
    }

    public void DisconnectDevices(IConnectable device1, IConnectable device2)
    {
        device1.Disconnect(device2);
        device2.Disconnect(device1);
    }

    public void TransmitData(IConnectable sender, IConnectable receiver, string data)
    {
        sender.TransmitData(data);
        receiver.TransmitData(data);
    }
}