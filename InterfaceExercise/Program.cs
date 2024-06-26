using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                NumberOfWheels = 4,
                EngineType = 4,
                ExteriorColor =  "Yellow",
                InteriorColor = "Blue",
                
            };
            var truck = new Truck()
            {
                NumberOfWheels = 8,
                EngineType = 4,
                ExteriorColor = "Black",
                InteriorColor = "Blue",
                

            };
           var suv = new SUV();
            suv.NumberOfWheels = 4;
            suv.EngineType = 5;
            suv.ExteriorColor = "Red";
            suv.InteriorColor = "Black";


            var vehicles = new List<IVehicle>() { car, truck, suv };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($" {vehicle.NumberOfWheels} {vehicle.EngineType} {vehicle.ExteriorColor} {vehicle.InteriorColor}");
                vehicle.ChangeGears(true);
                
            } 
            
        }
    }
}
