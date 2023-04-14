using System;

namespace LP1_Project1
{
    /// <summary>
    /// Class contains the method Main() where the program will start running
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main() is where the Program starts running. It calls the relevant
        /// methods in order to have the game work properly
        /// </summary>
        static void Main()
        {
            //Initialize a bool as false
            bool win = false;
            //Initialize the state of the lamps as 0 (all off)
            LampState currentState = 0;

            //Write the state of all lamps
            Output.Lamps(currentState);

            //Initialize a for loop that covers the number of allowed turns
            for (int i = 1; i < 7; i++)
            {
                //Write which turn we're on
                Console.WriteLine($"\nTurn {i}");

                //Allow the player to press a button and switch the state of
                //the lamps accordingly
                currentState = Resolvers.Lamps(Selectors.Button(), currentState);
                //Write the status of the lamps and assign the value true
                //to the bool if the win condition has been met
                win = Output.Lamps(currentState);

                //If the win condition has been met
                if (win)
                {
                    //Break the loop
                    break;
                }
            }
            //Once the loop has been broken
            //If the win condition has not been met
            if(!win)
            {
                //Write the loss message
                Output.Lose();
            }
        }
    }
}