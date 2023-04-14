using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    /// <summary>
    /// Class which contains methods that allow the player to interact
    /// with the game
    /// </summary>
    public class Selectors
    {
        /// <summary>
        /// Asks the player to choose which button to press and returns the
        /// player's option
        /// </summary>
        /// <returns>The int with the option selected by the player</returns>
        public static int Button()
        {
            //Initialize the int which will store the player's option
            int option;

            //Initialize a loop
            while(true)
            {
                //Ask the player for which button they wish to press
                Console.Write("Please select a button to press (1,2,3): ");
                //Store the player's input
                string s_option = Console.ReadLine();
                
                //Try to convert the player's input into an int
                if(int.TryParse(s_option, out option))
                {}
                //If the player's input cannot be converted into an int
                else
                {
                    //Inform the player that the input's type is invalid
                    Console.WriteLine("Invalid Type!");
                    //Request the player to try again
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    //Return to the beginning of the loop
                    continue;
                }

                //If the player's input can be converted into an int but does
                //not have a value within the allowed ones.
                if(option < 1 | option > 3)
                {
                    //Inform the player that the value is not allowed
                    Console.WriteLine("Option is not a valid value!");
                    //Request the player to try again
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    //Return to the beginning of the loop
                    continue;
                }
                //If all the checks were successful until now, break the loop
                break;
            }
            //If we break the loop, return the int with the player's input
            return option;
        }
    }
}