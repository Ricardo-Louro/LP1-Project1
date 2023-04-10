using System;

namespace LP1_Project1
{
        [Flags]
        public enum LampState
        {
            Lamp1 = 1 << 0, // 1
            Lamp2 = 1 << 1, // 2
            Lamp3 = 1 << 2 // 4
        }
}