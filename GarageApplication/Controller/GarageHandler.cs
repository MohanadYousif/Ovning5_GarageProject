
namespace GarageApplication.Controllers
{
    public class GarageHandler : IGarageHandler
    {
        private Garage<Vehicle> garage;
        private Vehicle[] vehicles;
        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            vehicles = garage.Vehicles;
        }

        // Metod för att lista samtliga parkerade fordon
        public Vehicle[] GetAllVehicles()
        {
            return vehicles;
        }

        // Metod för att lista fordonstyper och antal i garaget
        public IEnumerable<IGrouping<string, Vehicle>> GetVehicleTypes()
        {
            return vehicles.Where(v => v != null).GroupBy(v => v.GetType().Name);

        }

        // Metod för att lägga till ett fordon i garaget
        public void ParkVehicle(Vehicle vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine("Garage is full, cannot park more vehicles.");
                return;
            }

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    Console.WriteLine($"{vehicle.GetType().Name} with Reg. No {vehicle.RegistrationNumber} parked successfully.");
                    break;
                }
            }
        }

        // Metod för att ta bort ett fordon från garaget
        public void RemoveVehicle(string registrationNumber)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null && vehicles[i].RegistrationNumber.Equals(registrationNumber))
                {
                    Console.WriteLine($"{vehicles[i].GetType().Name} with Reg. No {vehicles[i].RegistrationNumber} removed successfully.");
                    vehicles[i] = null;
                    break;
                }
            }
        }

        // Method to find a specific vehicle by registration number
        public Vehicle GetVehiclesByRegNumber(string registrationNumber)
        {
            return garage.FirstOrDefault(vehicle => string.Equals(vehicle.RegistrationNumber.ToUpper(), registrationNumber.ToUpper()));
        }

        public IEnumerable<Vehicle> SearchVehicles(Func<Vehicle, bool> predicate)
        {
            return garage.Where(predicate);
        }
        private bool IsFull()
        {
            return vehicles.All(v => v != null);
        }

    }
}
