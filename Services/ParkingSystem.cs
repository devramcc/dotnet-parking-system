using dotnet_parking_system.Models;

namespace dotnet_parking_system.Services
{
    public class ParkingSystem
    {
        public ParkedVehicle[] ParkedVehicles;

        public ParkingSystem(int parkingLot)
        {
            ParkedVehicles = new ParkedVehicle[parkingLot];
        }

        public ParkedVehicle[] AddVehicle()
        {
            Vehicle vehicle = new Vehicle
            {
                Name = "Honda",
                NoRegistration = "001",
                VehicleType = VehicleType.Mobil,
                Color = "Black"
            };
            ParkedVehicle parkedVehicle = new ParkedVehicle {
                Vehicle = vehicle,
                ParkedAt = DateTime.Now
            };
            this.ParkedVehicles[0] = parkedVehicle;
            return this.ParkedVehicles;
        }
    }
}