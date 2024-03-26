using GarageApplication.Controllers;

namespace GarageApplication
{
    internal class Program
    {
        static GarageHandler garageHandler = new GarageHandler(10);
        static void Main(string[] args)
        {
            var vehicles = new Vehicle[]
                {
                    new Car("ABC123", "Red", 4, 5),
                    new Motorcycle("DEF456", "Blue", 2, false),
                    new Bus("GHI789", "Yellow", 6, 50)
                };

            // Skapa ett garage med en användar specificerad storlek

            foreach (var vehicle in vehicles)
            {
                garageHandler.ParkVehicle(vehicle);
            }

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWelcome to Garage Management System");
                Console.WriteLine("1. List all parked vehicles");
                Console.WriteLine("2. List vehicle types and counts");
                Console.WriteLine("3. Park a vehicle");
                Console.WriteLine("4. Remove a vehicle");
                Console.WriteLine("5. Search a vehicle by registration number");
                Console.WriteLine("6. Exit");

                Console.Write("Please select an option: ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListAllVehicles();
                        break;
                    case "2":
                        ListVehicleTypes();
                        break;
                    case "3":
                        garageHandler.ParkVehicle(parkVehicleInGarage());
                        break;
                    case "4":
                        Console.Write("Enter the registration number of the vehicle to remove: ");
                        string? regNo = Console.ReadLine();
                        garageHandler.RemoveVehicle(regNo);
                        break;
                    case "5":
                        Console.Write("Enter the registration number of the vehicle to search: ");
                        string? seaRegNo = Console.ReadLine();
                        var vehicle = garageHandler.SearchVehicles(v => v.RegistrationNumber.ToUpper() == seaRegNo.ToUpper()).FirstOrDefault();
                        Console.WriteLine($"{vehicle.GetType().Name} with Reg. No {vehicle.RegistrationNumber} Found successfully.");
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        private static void ListAllVehicles()
        {
            foreach (var vehicle in garageHandler.getAllVehicles())
            {
                if (vehicle != null)
                {
                    Console.WriteLine($"{vehicle.GetType().Name} - Reg. No: {vehicle.RegistrationNumber}, Color: {vehicle.Color}");
                }
            }
        }

        private static void ListVehicleTypes()
        {
            foreach (var group in garageHandler.getVehicleTypes())
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
        }

        private static Vehicle parkVehicleInGarage()
        {
            Console.Write("Enter car's registration number: ");
            string? reg = Console.ReadLine();

            Console.Write("Enter car's color : ");
            string? color = Console.ReadLine();

            Console.Write("Enter car's number Of Wheels: ");
            int numberOfWheels = Int32.Parse(Console.ReadLine());

            Console.Write("Enter car's Number Of Seats: ");
            int NumberOfSeats = Int32.Parse(Console.ReadLine());

            return new Car(reg, color, numberOfWheels, NumberOfSeats);
        }

        //private static void searchVehicle()
        //{
        //    Console.WriteLine("1. Search a vehicle by Reg N.");
        //    Console.WriteLine("2. Search a vehicle by color and number of wheels ");
        //    Console.WriteLine("3. Search a vehicle by type, color and number of wheels");
        //    Console.WriteLine("4. Search a vehicle by type ");
        //    Console.WriteLine("5. Search a vehicle by color ");


        //}
    }
}
