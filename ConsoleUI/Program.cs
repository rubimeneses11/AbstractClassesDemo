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
            // DONE-Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
            * DONE-Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type 
            * DONE-Vehicle (use explicit typing) but use constuctors from derived classes
            * DONE- create an instance as one of each derived class
            * DONE-Set the properties with object initializer syntax
            */

            Car rubisCar = new Car()
            {
                HasTrunk = true,
                Make = "Ford",
                Model = "F-150",
                Year = 2023
            };

            Motorcyle rubisMotorcycle = new Motorcyle()
            {
                HasSideCart = true,
                Make = "Honda",
                Model = "Scoopy",
                Year = 2017
            };

            //of type vehicle but using the car constructor
            Vehicle workCar = new Car()
            {
                HasTrunk = true,
                Make = "Land Rover",
                Model = "Range Rover",
                Year = 2017
            };

            Vehicle funCar = new Car()
            {
                Make = "Porsche",
                Model = "Cayenne",
                Year = 2022
            };


            /* 
             * DONE- Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE- Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE-Provide the implementations for the abstract methods
             * DONE- Only in the Motorcycle class will you override the virtual drive method
            */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            //list name.Add(name of objects)
            vehicles.Add(rubisCar);
            vehicles.Add(rubisMotorcycle);
            vehicles.Add(workCar);
            vehicles.Add(funCar);

            foreach (var whip in vehicles)
            {
                Console.WriteLine($"Make: {whip.Make}, Model: {whip.Model}, Year: {whip.Year}");
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            //instance.Method();
            rubisCar.DriveAbstract();
            rubisMotorcycle.DriveVirtual();
            workCar.DriveAbstract();
            funCar.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
