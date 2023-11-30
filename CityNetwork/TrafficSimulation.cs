public class TrafficSimulation
{
    public void SimulateTraffic(Vehicle vehicle, Road road)
    {
        Console.WriteLine($"Simulating traffic on a road of length {road.Length} km with {road.NumberOfLanes} lanes.");

        if (road.TrafficLevel > 50)
        {
            Console.WriteLine("Traffic is heavy. Vehicles may experience delays.");
        }

        vehicle.Move();
        vehicle.Stop();
    }
}