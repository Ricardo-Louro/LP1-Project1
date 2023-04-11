using System;

namespace LP1_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            LampState currentState = 0;
            currentState = Resolvers.Lamps(Selectors.Button(), currentState);
            Console.WriteLine((currentState & LampState.Lamp1) == LampState.Lamp1);
        }
    }
}
