namespace DesignPatterns
{
    public class SportsCarBuilder : ICarBuilder
    {
        public Car Product { get; set; }
        readonly CarBuilderArgs args;


        public Car product;
        public SportsCarBuilder(CarBuilderArgs args)
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
            product.NumberOfWheels = 4;
        }
    }
}
