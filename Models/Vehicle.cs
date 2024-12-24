namespace dotnet_parking_system.Models
{
    public class Vehicle
    {
        public required string Name { get; set; }
        public required string NoRegistration { get; set; }
        public VehicleType VehicleType { get; set; }
        public required string Color { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Registration: {NoRegistration}, Type: {VehicleType}, Color: {Color}";
        }
    }
}