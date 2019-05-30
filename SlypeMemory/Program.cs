using System;
using System.Text;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace assaultcube_cheat_v2
{
    class Program
    {
        // Exits program nicely.
        public static void exitProgram(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void Main()
        {
            // ---------------- Example below ---------------- //

            // Init SlypeMemory Class
            SlypeMemory hook = new SlypeMemory("programNameHere", "accessLevelHere");
            if (hook.process == null) // Exit if it was unable to find the process
                exitProgram("Process is unable to be found, Press any key to exit.");

            // Open a handle
            if (!hook.openHandle()) // Exit if it was unable to open a handle
                exitProgram("Unable to open a handle, Press any key to exit.");

            // Read from an address
            int someValue = hook.readInt32(0x13337);

            // Write to an address
            hook.writeDouble(0x13337, 3.1415926535);
        }
    }
}
