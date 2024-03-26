
namespace GarageApplication
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle()
        {
        }
        public Motorcycle(string registrationNumber, string color, int numberOfWheels, bool HasSideCar) : base(registrationNumber, color, numberOfWheels)
        {
            this.HasSideCar = HasSideCar;
        }
    }
}
