using dotnet_parking_system.Models;
using dotnet_parking_system.Services;

namespace dotnet_parking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(6);
            ParkedVehicle[] parkedVehicles = parkingSystem.AddVehicle();
            Console.WriteLine(parkedVehicles[0].ParkedAt);
            Console.WriteLine(parkedVehicles[0].Vehicle.ToString());
        }
    }
}