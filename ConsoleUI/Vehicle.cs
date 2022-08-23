using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    /*
 * DONE- Create an abstract class called Vehicle
 * DONE- The vehicle class shall have three string properties Year, Make, and Model
 * Set the defaults to something generic in the Vehicle class
 * Vehicle shall have an abstract method called DriveAbstract with no implementation
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
 */
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }
        public int Year { get; set; } = 2010;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Pilot";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This vehicle can drive itself!");
        }
    }
}

