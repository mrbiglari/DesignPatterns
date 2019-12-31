namespace DesignPatterns
{
    public class TableBuilder : builder<Table>
    {
        public Table Product { get; set; }

        public void Build()
        {
            Product = new Table() { NumberOfLegs = 4 };
        }

        public Table GetProduct()
        {
            return Product;
        }
    }
}
