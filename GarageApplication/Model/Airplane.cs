
namespace GarageApplication
{
    internal class Airplane : Vehicle
    {
        private int NumberOfEngines { get; set; }

        public Airplane()
        {
        }
        public Airplane(string registrationNumber, string color, int numberOfWheels, int NumberOfEngines)
            : base(registrationNumber, color, numberOfWheels)
        {
            this.NumberOfEngines = NumberOfEngines;
        }


    }
}
