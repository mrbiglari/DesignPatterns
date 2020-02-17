namespace DesignPatterns.Creational.Prototype
{
    public class Screen : IPrototype<Screen>
    {
        public string Resolution { get; set; }
        public int DPI { get; set; }
        public string Dimensions { get; set; }
        public Screen(Screen screen)
        {
            Resolution = screen.Resolution;
            DPI = screen.DPI;
            Dimensions = screen.Dimensions;
        }

        public Screen()
        {
        }

        public Screen Clone()
        {
            return new Screen(this);
        }
    }
}
