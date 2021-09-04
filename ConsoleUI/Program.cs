﻿using System;
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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Done - Create an abstract class called Vehicle
             * Done - The vehicle class shall have three string properties Year, Make, and Model
             * Done - Set the defaults to something generic in the Vehicle class
             * Done - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Done - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *Done - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             *Done - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             *Done - Provide the implementations for the abstract methods
             *Done Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car helio = new Car() { HasTrunk = true, Make = "Delta", Model = "Helio", Year = 2025 };
            Motorcycle b22 = new Motorcycle() { HasTwoWheels = true, Make = "Cobalt", Model = "B22", Year = 2022 };

            Vehicle crion = new Car() { HasTrunk = false, Make = "Delta", Model = "Crion", Year = 2023 };
            Vehicle sentinel = new Car() { Make = "Delta", Model = "Sentinel", Year = 2025 };

            /*
            * Add the 4 vehicles to the list
            * Using a foreach loop iterate over each of the properties
            */
            vehicles.Add(b22);
            vehicles.Add(crion);
            vehicles.Add(sentinel);
            vehicles.Add(helio);

            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                vehicle.DriveVirtual();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            
            #endregion            
            Console.ReadLine();
        }
    }
}
