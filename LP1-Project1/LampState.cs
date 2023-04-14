using System;

namespace LP1_Project1
{
    //Define the Enum with FlagsAttribute 
    [Flags]
    public enum LampState
    {
        //Define Lamp1 value (1)
        Lamp1 = 1 << 0,
        //Define Lamp2 value (2)
        Lamp2 = 1 << 1,
        //Define Lamp3 value (4)
        Lamp3 = 1 << 2
    }
}