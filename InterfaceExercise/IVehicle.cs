namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        bool HasWheels { get; set; }

        public void Drive();
    }
}