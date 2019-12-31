namespace DesignPatterns
{
    class SingletonProgram
    {
        public static void MainMethod(string[] args)
        {
            var singletonA = Singleton.GetSingleton();

            var singletonB = Singleton.GetSingleton();

            if (singletonA.GetHashCode() == singletonB.GetHashCode())
                return;
        }
    }
}

