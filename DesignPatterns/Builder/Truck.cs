namespace DesignPatterns
{
    public class TruckBuilder : ICarBuilder
    {
        public Car Product { get; set; }
        readonly CarBuilderArgs args;


        public Car product;
        public TruckBuilder(CarBuilderArgs args)
        {
            this.args = args;
        }

        public void Build()
        {
            product = new Car();
            BuildEngine();
            BuildChassis();
            BuildWheels();
        }

        public Car GetProduct()
        {
            return product;
        }

        public void BuildChassis()
        {
            product.Chassis = new Chassis();
        }

        public void BuildEngine()
        {
            product.Engine = new Engine();
        }

        public void BuildWheels()
        {
            product.NumberOfWheels = 8;
        }
    }
}
