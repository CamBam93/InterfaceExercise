using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; } = true;
        public bool HasSunRoof { get; set; } = false;
        public string Make { get ; set ; }
        public string Model { get ; set ; }
        public string Year { get ; set ; }
        public bool HasWheels { get; set; } = true;
        public bool HasLogo { get; set; } = true;
        public string CompanyName { get ; set ; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is in drive");
        }
    }
}
