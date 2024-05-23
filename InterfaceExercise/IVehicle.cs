using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
     public int NumberOfWheels { get; set; }
        public int EngineType { get; set;}
        public string ExteriorColor { get; set; }
        public string  InteriorColor { get; set; }
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged);

        //Create a stubbed out method called DisplayDetails in your IVehicle interface.

        public void DisplayDetails();


    }
}
