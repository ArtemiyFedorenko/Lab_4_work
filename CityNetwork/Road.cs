public class Road
{
    private double length;
    private double width;
    private int numberOfLanes;
    private int trafficLevel;

    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public int NumberOfLanes
    {
        get { return numberOfLanes; }
        set { numberOfLanes = value; }
    }
    public int TrafficLevel
    {
        get { return trafficLevel; }
        set { trafficLevel = value; }
    }

    public Road(double length, double width, int numberOfLanes, int trafficLevel)
    {
        Length = length;
        Width = width;
        NumberOfLanes = numberOfLanes;
        TrafficLevel = trafficLevel;
    }
}