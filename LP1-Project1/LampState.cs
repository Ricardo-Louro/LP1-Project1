using System;

namespace LP1_Project1
{
        [Flags]
        public enum LampState
        {
            Lamp1 = 1 << 0, // 0
            Lamp2 = 1 << 1, // 0
            Lamp3 = 1 << 2 // 0
        }
}