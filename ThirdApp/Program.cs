using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal tiger = new Animal("Tiger", 60, 6, 12);
        Animal deer = new Animal("Deer", 25, 3, 7);

        Plant oakTree = new Plant("Oak Tree", 40, 20);
        Plant wildFlower = new Plant("Wild Flower", 3, 1);

        Microorganism algae = new Microorganism("Algae", 2, 1);

        ecosystem.AddOrganism(tiger);
        ecosystem.AddOrganism(deer);
        ecosystem.AddOrganism(oakTree);
        ecosystem.AddOrganism(wildFlower);
        ecosystem.AddOrganism(algae);

        ecosystem.Simulate(5);
    }
}
