using FactoryDesignPatternExam.Vehicles;

namespace FactoryDesignPatternExam.Factories;

public abstract class VehicleCreator
{
    protected abstract Vehicle MakeVehicle();

    public Vehicle CreateVehicle()
    {
        return MakeVehicle();
    }
}
