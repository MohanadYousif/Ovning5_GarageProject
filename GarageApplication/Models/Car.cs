
namespace GarageApplication
{
    public class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Car(string registrationNumber, string color, int numberOfWheels, int NumberOfSeats) : base(registrationNumber, color, numberOfWheels)
        {
            this.NumberOfSeats = NumberOfSeats;
        }
    }
}
