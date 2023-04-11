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
                
            }
            else if(Button == 3)
            {

            }
            else
            {
                Console.WriteLine("Unexpected Exception!");
            }

            return currentState;
        }
    }
}