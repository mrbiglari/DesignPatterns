namespace DesignPatterns.Creational.Prototype
{
    public class Camera : IPrototype<Camera>
    {
        public int MegaPixeles { get; set; }
        public int Aprature { get; set; }
        public int FieldOfDepth { get; set; }
        public Camera(Camera camera)
        {
            MegaPixeles = camera.MegaPixeles;
            Aprature = camera.Aprature;
            FieldOfDepth = camera.FieldOfDepth;
        }

        public Camera()
        {
        }

        public Camera Clone()
        {
            return new Camera(this);
        }
    }
}
