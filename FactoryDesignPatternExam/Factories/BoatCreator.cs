using FactoryDesignPatternExam.Vehicles;

namespace FactoryDesignPatternExam.Factories;

public class BoatCreator : VehicleCreator
{
    protected override Vehicle MakeVehicle()
    {
        Vehicle vehicle = new Boat();
        vehicle.Capacity = 150;
        return vehicle;
    }
}
