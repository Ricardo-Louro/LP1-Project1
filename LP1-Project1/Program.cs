using System;

namespace LP1_Project1
{
    class Program
    {
        static void Main()
        {
            bool win = false;
            LampState currentState = 0;          

            for(int i = 1; i < 7; i++)
            {
                Console.WriteLine($"Turn {i}");

                currentState = Resolvers.Lamps(Selectors.Button(), currentState);
                win = Output.Lamps(currentState);

                if(win)
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