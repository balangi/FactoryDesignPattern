namespace FactoryDesignPatternExam.Vehicles;

public abstract class Vehicle
{
    public int Capacity { get; set; }

    public abstract string GetData();

    public void AddPassenger(int passengers)
    {
        if (Capacity < passengers)
        {
            throw new Exception(GetData() + " reached max capacity");
        }
        else
        {
            Capacity -= passengers;
        }
    }
}
