using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    public class Selectors
    {
        public static int Button()
        {
            int option;

            while(true)
            {
                Console.Write("Please select a button to press (1,2,3): ");
                string s_option = Console.ReadLine();
                
                if(int.TryParse(s_option, out option))
                {}
                else
                {
                    Console.WriteLine("Invalid Type!");
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    continue;
                }

                if(option < 1 | option > 3)
                {
                    Console.WriteLine("Option is not a valid value!");
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    continue;
                }

                break;
            }
            
            return option;
        }
    }
}