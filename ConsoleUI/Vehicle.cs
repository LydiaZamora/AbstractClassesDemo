using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        /*
         * Set the defaults of the properties to something generic in the Vehicle class
         * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
         * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
         */

        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }


        
    }
}

