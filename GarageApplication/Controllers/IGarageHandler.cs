namespace GarageApplication.Controllers
{
    internal interface IGarageHandler
    {
        public Vehicle[] getAllVehicles();
        public IEnumerable<IGrouping<string, Vehicle>> getVehicleTypes();
        public void ParkVehicle(Vehicle vehicle);
        public void RemoveVehicle(string registrationNumber);
        //public void GetVehiclesByRegNumber(string regN);
        public IEnumerable<Vehicle> SearchVehicles(Func<Vehicle, bool> predicate);
    }
}
