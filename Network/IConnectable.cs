public interface IConnectable
{
    void Connect(IConnectable device);
    void Disconnect(IConnectable device);
    void TransmitData(string data);
}