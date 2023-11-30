using System;

class Program
{
    static void Main()
    {
        Road mainRoad = new Road(10.5, 4.0, 2, 60);
        Vehicle car = new Vehicle(60.0, 3.0, "Car");

        TrafficSimulation simulation = new TrafficSimulation();
        simulation.SimulateTraffic(car, mainRoad);
    }
}
