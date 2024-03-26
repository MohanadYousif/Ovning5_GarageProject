namespace GarageApplication.Controllers
{
    internal interface IGarageHandler
    {
        public Vehicle[] GetAllVehicles();
        public IEnumerable<IGrouping<string, Vehicle>> GetVehicleTypes();
        public void ParkVehicle(Vehicle vehicle);
        public void RemoveVehicle(string registrationNumber);
        public Vehicle GetVehiclesByRegNumber(string registrationNumber);
        public IEnumerable<Vehicle> SearchVehicles(Func<Vehicle, bool> predicate);
    }
}
