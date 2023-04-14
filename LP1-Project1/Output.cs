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

            Console.WriteLine($"\nLamp 1: " + (lamp1 == true ? "On" : "Off")); //se o estado da lâmpada for verdadeira, então mostra que está ligado, caso contrário mostra que está desligada
            Console.WriteLine($"Lamp 2: " + (lamp2 == true ? "On" : "Off"));   //se o estado da lâmpada for verdadeira, então mostra que está ligado, caso contrário mostra que está desligada
            Console.WriteLine($"Lamp 3: " + (lamp3 == true ? "On" : "Off"));   //se o estado da lâmpada for verdadeira, então mostra que está ligado, caso contrário mostra que está desligada

            if(lamp1 && lamp2 && lamp3)
            {
                win = Win();
            }
            return win;
        }

        public static bool Win()
        {
            Console.WriteLine("\nCongratulations! You have won!");
            return true;
        }

        public static void Lose()
        {
            Console.WriteLine("\nTurn limit reached!");
            Console.WriteLine("Better luck next time!");
        }
    }
}