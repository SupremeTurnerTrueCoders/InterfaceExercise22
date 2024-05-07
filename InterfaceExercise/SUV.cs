using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV :IVehicle, ICompany
    {
    }
    public int NumberOfWheels { get; set; } = 4;
    public int EngineType { get; set; } = 8;
    public string ExteriorColor { get; set; } = "Blue";
    public string InteriorColor { get; set; } = "Crimson";
    public string Logo { get; set; } = "Mercedez Benz";
    public string Motto { get; set; } = "The Best Or Nothing";
    public bool HasChangedGears { get; set; }

    public bool HasFourWheelDrive { get; set; } = true;


    public void Drive()
    {
        if (HasFourWheelDrive == true)
        {
            Console.WriteLine($"4 wheel drive {GetType().Name} now driving foward...)
        }
        else
        {
            Console.WriteLine($"{GetType().Name} now driving foward...)
        }
    }
    public void Reverse()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now reversing...)

            HasChangedGears = false;
        }
        else
        {
            Console.WriteLine("Can't reverse until we change gears");
        }


    }

    public void Park()
    {
        if (HasChangedGears == true)
        {
            Console.WriteLine($"{GetType().Name} now reversing...)

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
}
