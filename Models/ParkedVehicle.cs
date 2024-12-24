namespace dotnet_parking_system.Models
{
    public class ParkedVehicle
    {
        public Vehicle Vehicle { get; set; }
        public DateTime ParkedAt { get; set; }

        public ParkedVehicle(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
            this.ParkedAt = DateTime.Now;
        }
    }
}