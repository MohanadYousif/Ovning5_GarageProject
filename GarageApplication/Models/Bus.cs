
namespace GarageApplication
{
    internal class Bus : Vehicle
    {
        public int NumberOfPassengers { get; set; }
        public Bus(string registrationNumber, string color, int numberOfWheels, int NumberOfPassengers) : base(registrationNumber, color, numberOfWheels)
        {
            this.NumberOfPassengers = NumberOfPassengers;
        }
    }
}
