
namespace GarageApplication
{
    internal class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public Boat(string registrationNumber, string color, int numberOfWheels, string BoatType)
        : base(registrationNumber, color, numberOfWheels)
        {
            this.BoatType = BoatType;
        }
    }
}
