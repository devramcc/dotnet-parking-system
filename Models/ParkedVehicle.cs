namespace dotnet_parking_system.Models
{
    public class ParkedVehicle
    {
        public required Vehicle Vehicle { get; set; }
        public required DateTime ParkedAt { get; set; }
    }
}