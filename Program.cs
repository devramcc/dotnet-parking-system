using dotnet_parking_system.Models;
using dotnet_parking_system.Services;

namespace dotnet_parking_system
{
    class Program
    {
        static void Main(string[] args)
        {
            // ParkingSystemService parkingSystemService = new ParkingSystemService(6);
            // ParkedVehicle[] parkedVehicles = parkingSystemService.AddVehicle();
            // Console.WriteLine(parkedVehicles[3].ParkedAt);
            // Console.WriteLine(parkedVehicles[3].Vehicle.ToString());
            // Console.WriteLine(string.Join(", ", parkingSystemService.GetAllEmptyParkingLot()));
            DisplayConsoleService displayConsoleService = new DisplayConsoleService();
            displayConsoleService.Start();
        }
    }
}