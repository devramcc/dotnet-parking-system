namespace dotnet_parking_system.Services
{
    public class DisplayConsoleService
    {
        public ParkingSystemService parkingSystemService;

        public DisplayConsoleService()
        {
            Console.WriteLine("=============================");
            Console.Write("Enter Parking Lot Size : ");
            int parkingLot = int.Parse(Console.ReadLine());
            Console.WriteLine("=============================");
            Console.Write("Parking Lot Size is ");
            Console.WriteLine(parkingLot);

            this.parkingSystemService = new ParkingSystemService(parkingLot);
        }
        public void Start()
        {
            int commandNumber = 0;
            while (commandNumber != 8)
            {
                Console.WriteLine("=============================");
                Console.WriteLine("Main Menu :");
                Console.WriteLine("=============================");
                Console.WriteLine("1. Check In");
                Console.WriteLine("2. Check Out");
                Console.WriteLine("3. Report Occpuied Lot");
                Console.WriteLine("4. Report Available Lot");
                Console.WriteLine("5. Report By Odd and Even Registration Number");
                Console.WriteLine("6. Report By Vehicle Type");
                Console.WriteLine("7. Report By Vehicle Color");
                Console.WriteLine("8. Exit");
                Console.WriteLine("=============================");
                Console.Write("Enter Command Number : ");
                commandNumber = int.Parse(Console.ReadLine());

                switch (commandNumber)
                {
                    case 1:
                        CheckIn();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;
                }
            }
        }

        public void CheckIn()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Park New Vehicle");
            Console.WriteLine("=============================");

            Console.Write("Enter Vehicle Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Vehicle Registration Number : ");
            string noRegistration = Console.ReadLine();
            Console.Write("Enter Vehicle Type : ");
            string nameVehicleType = Console.ReadLine();
            Console.Write("Enter Vehicle Color : ");
            string color = Console.ReadLine();
            string message = parkingSystemService.checkIn(name, noRegistration, nameVehicleType, color);

            Console.WriteLine("=============================");
            Console.WriteLine(message);
            Console.WriteLine("=============================");
        }
    }
}