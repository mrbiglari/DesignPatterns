namespace DesignPatterns
{
    public class CarBuilder : builder<Car>
    {
        public Car Product { get; set; }
        readonly CarBuilderArgs args;


        public Car product;
        public CarBuilder(CarBuilderArgs args)
        {
            this.args = args;
        }

        public void Build()
        {
            product = new Car() { NumberOfWheels = 10 };
        }

        public Car GetProduct()
        {
            return product;
        }
    }
}
