using System;
namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public Truck()
        {
        }
        public int haulingCapacity { get; set; } = 4000;
        public double bedLength { get; set; } = 6.2;

        public int NumberOfDoors { get; set; } = 3;
        public string Model { get; set; } = "Ram";
        public string VehicleColor { get; set; } = "Black";
        public int MaxSpeed { get; set; } = 120;

        public string CompanyName { get; set; } = "Dodge";
        public string Slogan { get; set; } = "Guts. Glory. Ram.";
    }
}