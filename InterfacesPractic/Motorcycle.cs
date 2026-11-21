using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPractic
{
    class Motorcycle : IDrivable
    {
        public void StartEngine()
        {
            Console.WriteLine("Motorcycle engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motorcycle engine stopped.");
        }

        public void Drive()
        {
            Console.WriteLine("Motorcycle is riding fast.");
        }
    }
}
