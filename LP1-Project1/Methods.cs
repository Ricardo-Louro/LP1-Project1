using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LP1_Project1
{
    public class Methods
    {
        public static int SelectButton()
        {
            int option;

            while (true)
            {
                Console.Write("Please select a button to press (1,2,3): ");
                string s_option = Console.ReadLine();
                
                try
                {
                    option = int.Parse(s_option);
                }
                catch
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

                Console.WriteLine("Option has been successfully declared!");
                break;
            }

            return option;
        }  
    }
}