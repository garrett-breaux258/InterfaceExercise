using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public string Model {get; set;}
        public string VehicleColor { get; set; }
        public int MaxSpeed { get; set; }
    }

}
