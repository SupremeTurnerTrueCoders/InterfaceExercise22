using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
     public Car()
        {
        }

        public int NumberOfWheels { get; set; } 
        public int EngineType { get; set; } 
        public string ExteriorColor { get; set; } 
        public string InteriorColor { get; set; } 
        public string Logo { get; set; } 
        public string Motto { get; set; } 
        public bool HasChangedGears { get; set; }
        public string SignatureCar { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving foward...");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

            
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

       

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{NumberOfWheels}, {EngineType}, {ExteriorColor}, {InteriorColor}, {Logo}, {Motto}, {HasChangedGears}, {SignatureCar}");
        }
    }
}
