using FactoryDesignPatternExam.Vehicles;

namespace FactoryDesignPatternExam.Factories;

public class BusCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Bus();
        vehicle.Capacity = 50;
        return vehicle;
    }
}
