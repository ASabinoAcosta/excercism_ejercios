using System;
using System.Collections.Generic;

public interface IRemoteControlCar
{
    void Drive();
    int DistanceTravelled { get; }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    private int distanceTravelled;

    public int NumberOfVictories { get; set; }

    public int DistanceTravelled
    {
        get
        {
            return distanceTravelled;
        }
    }

    public void Drive()
    {
        distanceTravelled += 10;
    }

    public int CompareTo(ProductionRemoteControlCar other)
    {
        if (other == null)
        {
            return 1;
        }

        return NumberOfVictories.CompareTo(other.NumberOfVictories);
    }
}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    private int distanceTravelled;

    public int DistanceTravelled
    {
        get
        {
            return distanceTravelled;
        }
    }

    public void Drive()
    {
        distanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(
        ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        var cars = new List<ProductionRemoteControlCar> { prc1, prc2 };
        cars.Sort();
        return cars;
    }
}
