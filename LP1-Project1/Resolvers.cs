using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    public class Resolvers
    {
        public static LampState Lamps(int Button, LampState currentState)
        {
            if(Button == 1)
            {
                currentState ^= LampState.Lamp1;
            }
            else if(Button == 2)
            {
                if (((currentState & LampState.Lamp1) == LampState.Lamp1) ^
                ((currentState & LampState.Lamp2) == LampState.Lamp2))
                {
                    currentState ^= LampState.Lamp1;
                    currentState ^= LampState.Lamp2;
                }
            }
            else if(Button == 3)
            {
                if (((currentState & LampState.Lamp2) == LampState.Lamp2) ^
                ((currentState & LampState.Lamp3) == LampState.Lamp3))
                {
                    currentState ^= LampState.Lamp2;
                    currentState ^= LampState.Lamp3;
                }
            }
            else
            {
                Console.WriteLine("Unexpected Exception!");
            }

            return currentState;
        }
    }
}