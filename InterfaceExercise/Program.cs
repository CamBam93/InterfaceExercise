using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //Create 2 Interfaces called IVehicle & ICompany
            //Create 3 classes called Car , Truck , & SUV
            //In your IVehicle          
            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            //In ICompany           
            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
            //In each of your car, truck, and suv classes
            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var vehic1 = new Car() {Make = "Chevy", Model = "Nova", Year = "1965" };
            var vehic2 = new Truck() { Make = "Toyota", Model = "Tacoma", Year = "1995", Has4WheelDrive = true};
            var vehic3 = new SUV() { Make = "Honda", Model = "CRV", Year = "2010" };

            var vehicles = new List<IVehicle>() { vehic1, vehic2, vehic3 };

            foreach(var v in vehicles)
            {
                Console.WriteLine($"Make: {v.Make}, Model: {v.Model}, Year: {v.Year}");
                v.Drive();

            }





        }
    }
}
