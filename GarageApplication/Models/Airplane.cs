
namespace GarageApplication
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Airplane(string registrationNumber, string color, int numberOfWheels, int NumberOfEngines)
            : base(registrationNumber, color, numberOfWheels)
        {
            this.NumberOfEngines = NumberOfEngines;
        }
    }
}
