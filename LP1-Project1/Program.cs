using System;

namespace LP1_Project1
{
    class Program
    {
        static void Main()
        {
            bool win = false;
            LampState currentState = 0;

            Output.Lamps(currentState);

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"\nTurn {i}");

                currentState = Resolvers.Lamps(Selectors.Button(), currentState);
                win = Output.Lamps(currentState);

                if (win)
                {
                    break;
                }
            }

            if(!win)
            {
                Output.Lose();
            }
        }
    }
}