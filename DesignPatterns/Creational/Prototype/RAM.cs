namespace DesignPatterns.Creational.Prototype
{
    public class RAM : IPrototype<RAM>
    {
        public int MemorySize { get; set; }
        public int MemorySpeed { get; set; }

        public RAM(RAM ram)
        {
            MemorySize = ram.MemorySize;
            MemorySpeed = ram.MemorySpeed;
        }

        public RAM()
        {
        }

        public RAM Clone()
        {
            return new RAM(this);
        }
    }
}
