namespace DesignPatterns.Creational.Prototype
{
    public class PrototypeProgram
    {
        public static void PrototypeMain(string[] args)
        {
            var mobile = BuildMobile();
            var shallowCopyOfMobile1 = mobile;
            var shallowCopyOfMobile2 = new Mobile()
            {
                Camera = mobile.Camera,
                RAM = mobile.RAM,
                Screen = mobile.Screen
            };

            var clonedMobile = mobile.Clone();

            clonedMobile.Camera.MegaPixeles = 100;
            clonedMobile.Screen.Resolution = "5000 x 4000";

            shallowCopyOfMobile1.Camera.MegaPixeles = 20;
            shallowCopyOfMobile1.Screen.Resolution = "720 x 480";
        }

        private static Mobile BuildMobile()
        {
            return new Mobile()
            {
                Camera = new Camera()
                {
                    Aprature = 1,
                    FieldOfDepth = 2,
                    MegaPixeles = 10
                },
                RAM = new RAM()
                {
                    MemorySize = 4,
                    MemorySpeed = 200
                },
                Screen = new Screen()
                {
                    Dimensions = "4.5 x 5.5",
                    DPI = 300,
                    Resolution = "1920 x 1024"
                }
            };
        }
    }
}
