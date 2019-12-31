namespace DesignPatterns
{
    class SingletonProgram
    {
        static void AMain(string[] args)
        {
            var singletonA = Singleton.GetSingleton();

            var singletonB = Singleton.GetSingleton();

            if (singletonA.GetHashCode() == singletonB.GetHashCode())
                return;
        }
    }
}

