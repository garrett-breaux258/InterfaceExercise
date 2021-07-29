using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany 
    {
        public SUV()
        {
        }
        public double cargoSize { get; set; } = 60;
        public bool isRearGlassSeparate { get; set; } = false;

        public int NumberOfDoors { get; set; } = 4;
        public string Model { get; set; } = "Rav4";
        public string VehicleColor { get; set; } = "Ruby Red";
        public int MaxSpeed { get; set; } = 140;

        public string CompanyName { get; set; } = "Toyota";
        public string Slogan { get; set; } = "Let's go places";
    }
}
