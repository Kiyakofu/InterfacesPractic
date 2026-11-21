using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesPractic
{
    class Car : IDrivable
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }

        public void Drive()
        {
            Console.WriteLine("Car is driving on the road.");
        }
    }
}
