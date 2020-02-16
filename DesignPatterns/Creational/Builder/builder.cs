namespace DesignPatterns
{
    public interface builder<TOut>
    {
        TOut Product { get; set; }
        void Build();
        TOut GetProduct();
    }
}
