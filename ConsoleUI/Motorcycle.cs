using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{

        public Motorcycle()
		{
		}

        public override void DriveAbstract()
        {
            Console.WriteLine("This mortocycle is in drive.");
        }

        public bool HasSideCart { get; set; } = false;

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is { GetType().BaseType.Name} is virtually in drive");
        }
    }
}

