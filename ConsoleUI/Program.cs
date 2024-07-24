using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Vehicles

            var vehicles = new List<Vehicle>();

            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };

            Motorcycle motorcycle = new Motorcycle() { HasSideCart = true, Year = 2020, Model = "Chopper", Make = "Harley" };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Dodge", Model = "van", Year = 2015 };

            Vehicle sport = new Car() {HasTrunk = false, Year = 1991, Model = "something", Make = "Ferari" };

            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sport);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model} ");
                vehicle.DriveAbstract();

            }

            motorcycle.DriveVirtual();

            focus.DriveVirtual();

      
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
