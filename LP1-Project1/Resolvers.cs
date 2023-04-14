using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    /// <summary>
    /// Class which contains the methods that alter values
    /// </summary>
    public class Resolvers
    {
        /// <summary>
        /// This method utilizes the player's input returned from
        /// Selectors.Button() to edit the current state of the lamps before
        /// returning the new state of the lamps after the changes made during
        /// this method
        /// </summary>
        /// <param name="Button">The player's input</param>
        /// <param name="currentState">The current state of the lamps</param>
        /// <returns>The new state of the lamps</returns>
        public static LampState Lamps(int Button, LampState currentState)
        {
            //If the player's input was 1
            if(Button == 1)
            {
                //Toggle the state of Lamp1
                currentState ^= LampState.Lamp1;
            }
            //If the player's input was 2
            else if(Button == 2)
            {
                //If the state of Lamp1 and Lamp2 are different
                if (((currentState & LampState.Lamp1) == LampState.Lamp1) ^
                ((currentState & LampState.Lamp2) == LampState.Lamp2))
                {
                    //Toggle the state of Lamp1
                    currentState ^= LampState.Lamp1;
                    //Toggle the state of Lamp2
                    currentState ^= LampState.Lamp2;
                }
            }
            //If the player's input was 3
            else if(Button == 3)
            {
                //If the state of Lamp2 and Lamp3 are different
                if (((currentState & LampState.Lamp2) == LampState.Lamp2) ^
                ((currentState & LampState.Lamp3) == LampState.Lamp3))
                {
                    //Toggle the state of Lamp2
                    currentState ^= LampState.Lamp2;
                    //Toggle the state of Lamp3
                    currentState ^= LampState.Lamp3;
                }
            }
            //If the player's input was neither of these values
            //Should never happen but we made this as a failsafe
            else
            {
                //Inform the player than an error has occurred
                Console.WriteLine("Unexpected Exception!");
            }
            //Return the new state of the lamps following the changes made
            //during this method
            return currentState;
        }
    }
}