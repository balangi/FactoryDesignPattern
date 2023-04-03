using FactoryDesignPatternExam.Vehicles;

namespace FactoryDesignPatternExam.Factories;

public class CarCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Car();
        vehicle.Capacity = 5;
        return vehicle;
    }
}
