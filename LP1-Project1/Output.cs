using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LP1_Project1
{
    /// <summary>
    /// Class contains the Methods which write output to the console
    /// </summary>
    public class Output
    {
        /// <summary>
        /// Writes the status of each lamp. Also checks if all of them are on
        /// (win condition) and if they are, calls Win() 
        /// </summary>
        /// <param name="currentState">The current status of the lamps so that
        /// it can be used to check which lamps are on or off.</param>
        /// <returns>A bool used to know if the win condition has been
        /// reached</returns>
        public static bool Lamps(LampState currentState, int Turn)
        {
            //Initialize the bool used to check if the win condition
            //has been reached
            bool win = false;

            //Declare a bool on whether Lamp1 is on
            bool lamp1 = (currentState & LampState.Lamp1) == LampState.Lamp1;
            //Declare a bool on whether Lamp2 is on
            bool lamp2 = (currentState & LampState.Lamp2) == LampState.Lamp2;
            //Declare a bool on whether Lamp3 is on
            bool lamp3 = (currentState & LampState.Lamp3) == LampState.Lamp3;

            //Wait for 0.5 seconds
            Thread.Sleep(500);
            //Write the status of Lamp1
            Console.WriteLine($"\nLamp 1: " + (lamp1 == true ? "On" : "Off"));
            
            //Wait for 0.5 seconds
            Thread.Sleep(500);
            //Write the status of Lamp2
            Console.WriteLine($"Lamp 2: " + (lamp2 == true ? "On" : "Off"));
            
            //Wait for 0.5 seconds
            Thread.Sleep(500);
            //Write the status of Lamp3
            Console.WriteLine($"Lamp 3: " + (lamp3 == true ? "On" : "Off"));

            //Wait for the player's input before proceeding
            Console.WriteLine();
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();

            //If all lamps are on...
            if(lamp1 && lamp2 && lamp3)
            {
                //...call method Win()
                win = Win(Turn);
            }
            //Return the bool used to check if the win condition was reached
            return win;
        }

        /// <summary>
        /// Writes a win message and returns true
        /// </summary>
        /// <returns>A bool used to know if the win condition has been
        /// reached</returns>
        public static bool Win(int Turn)
        {
            //Write win message
            Console.WriteLine("\nCongratulations! You have won!");
            Console.WriteLine("You have completed the game within " +
            $"{Turn} turns");

            //Wait for player's input before proceeding
            Console.WriteLine();
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
            
            //Return true
            return true;
        }

        /// <summary>
        /// Writes a loss message
        /// </summary>
        public static void Lose()
        {
            //Write loss message
            Console.WriteLine("\nTurn limit reached!");
            Console.WriteLine("Better luck next time!");

            //Wait for player's input before proceeding
            Console.WriteLine();
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }

        /// <summary>
        /// Writes a tutorial to inform the player of the rules for the game
        /// </summary>
        public static void Tutorial()
        {
            //Write the tutorial with pauses for readability
            Console.WriteLine("Welcome to the Game!");
            Thread.Sleep(1000);
            Console.WriteLine("You need to turn on all 3 lamps " +
            "within 6 turns or you'll lose!");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("Pressing Button 1 will turn on the first lamp!");
            Thread.Sleep(1000);
            Console.WriteLine("Pressing Button 2 will cause the first and " +
            "second lamps to switch states with each other!");
            Thread.Sleep(1000);
            Console.WriteLine("Pressing Button 3 will cause the second and " +
            "third lamps to switch states with each other!");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Best of luck!");

            //Wait for player's input before proceeding
            Console.Write("Press ENTER to proceed...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}