using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    public class Output
    {
        public static bool Lamps(LampState currentState)
        {
            bool win = false;

            bool lamp1 = (currentState & LampState.Lamp1) == LampState.Lamp1;
            bool lamp2 = (currentState & LampState.Lamp2) == LampState.Lamp2;
            bool lamp3 = (currentState & LampState.Lamp3) == LampState.Lamp3;

            Console.WriteLine($"Lamp 1: {lamp1}");
            Console.WriteLine($"Lamp 2: {lamp2}");
            Console.WriteLine($"Lamp 3: {lamp3}");

            if(lamp1 && lamp2 && lamp3)
            {
                win = Win();
            }

            return win;
        }

        public static bool Win()
        {
            Console.WriteLine("Congratulations! You have won!");
            return true;
        }

        public static void Lose()
        {
            Console.WriteLine("It seems you have lost! Better luck next time!");
        }
    }
}