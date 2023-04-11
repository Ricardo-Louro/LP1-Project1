using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    public class Checkers
    {
        public static void WinCheck(int turn, LampState lamps)
        {
            if (
            (lamps & LampState.Lamp1) == LampState.Lamp1 &&    // Verifica se a lâmpada 1 está ligada
            (lamps & LampState.Lamp2) == LampState.Lamp2 &&    // Verifica se a lâmpada 2 está ligada
            (lamps & LampState.Lamp3) == LampState.Lamp3 &&    // Verifica se a lâmpada 3 está ligada
            turn <= 6)                                         // Verifica se é o ultimo turno ou menor
            {
                Console.WriteLine($"Conseguiste resolver o puzzle em {turn} turnos. Ganhaste :)");
            }
            else if(turn > 6) // Verifica se ultrapassou o ultimo turno
            {
                Console.WriteLine($"Parece que já não tens mais turnos. Perdeste :(");
            }

            
        }  
    }
}