using System.Text;
using dotnet_parking_system.Models;

namespace dotnet_parking_system.Services
{
    public class ParkingSystemService
    {
        public ParkedVehicle[] ParkedVehicles;

        public ParkingSystemService(int parkingLot)
        {
            ParkedVehicles = new ParkedVehicle[parkingLot];
        }

        public string CheckIn(string name, string noRegistration, string nameVehicleType, string color)
        {
            Vehicle vehicle = new Vehicle
            {
                Name = name,
                NoRegistration = noRegistration,
                VehicleType = GetVehicleTypeByName(nameVehicleType),
                Color = color
            };

            if (getFirstEmptyParkingLot() != null)
            {
                int emptyLot = (int)getFirstEmptyParkingLot();
                ParkedVehicle parkedVehicle = new ParkedVehicle(vehicle);
                ParkedVehicles[emptyLot] = parkedVehicle;
                return $"Success park vehicle {name} with registration number {noRegistration} at {emptyLot}";

            }
            else
            {
                return "Failed to park vehicle";
            }
        }

        public string CheckOut(int indexParkingLot)
        {
            if (ParkedVehicles[indexParkingLot] == null)
            {
                return "Vehicle is never parked (not exist)";
            }
            DateTime parkedAt = ParkedVehicles[indexParkingLot].ParkedAt;
            TimeSpan timeElapsed = DateTime.Now - parkedAt;

            int hours = timeElapsed.Hours;
            int minutes = timeElapsed.Minutes;

            ParkedVehicles[indexParkingLot] = null;
            return $"Vehicle is checked out {hours} hours and {minutes} minutes after being parked.";
        }

        public string CheckAvailableLot()
        {
            List<int> availableLot = GetAllEmptyParkingLot();
            StringBuilder message = new StringBuilder();

            foreach (var item in availableLot)
            {
                message.Append($"Parking lot at {item} is empty. \n");
            }

            return message.ToString();
        }


        public VehicleType GetVehicleTypeByName(string name)
        {
            return (VehicleType)Enum.Parse(typeof(VehicleType), name, true);
        }
        public List<int> GetAllEmptyParkingLot()
        {
            List<int> result = new List<int>();

            for (int i = 0; i < ParkedVehicles.Length; i++)
            {
                if (ParkedVehicles[i] == null)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        public int? getFirstEmptyParkingLot()
        {
            for (int i = 0; i < ParkedVehicles.Length; i++)
            {
                if (ParkedVehicles[i] == null)
                {
                    return i;
                }
            }
            Console.WriteLine("Sorry, parking Lot is full.");
            return null;
        }
    }
}