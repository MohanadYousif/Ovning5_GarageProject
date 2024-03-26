
namespace GarageApplication
{
    public class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        // Andra egenskaper kan läggas till här

        public Vehicle(string RegistrationNumber, string Color, int NumberOfWheels)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.Color = Color;
            this.NumberOfWheels = NumberOfWheels;
        }
    }
}
