using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public double trunkSize { get; set; } = 33.5;
        public bool isHatchback { get; set; } = true;

        public int NumberOfDoors { get; set; } = 2;
        public string Model { get; set; } = "Mustang";
        public string VehicleColor { get; set; } = "White";
        public int MaxSpeed { get; set; } = 185;

        public string CompanyName { get; set; } = "Ford";
        public string Slogan { get; set; } = "Built Tough";
    }
}
