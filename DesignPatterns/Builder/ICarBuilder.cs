namespace DesignPatterns
{
    public interface ICarBuilder : builder<Car>
    {
        void BuildChassis();
        void BuildEngine();
        void BuildWheels();
    }
}