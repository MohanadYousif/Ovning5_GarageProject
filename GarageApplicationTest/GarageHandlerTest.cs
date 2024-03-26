using GarageApplication.Controllers;

namespace GarageApplication
{
    public class GarageHandlerTest
    {
        [Fact]
        public void ParkVehicle_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle = new Car("ABC123", "Red", 4, 5);

            // Act
            garageHandler.ParkVehicle(vehicle);

            // Assert
            Assert.Contains(vehicle, garageHandler.SearchVehicles(v => v != null));
        }

        [Fact]
        public void RemoveVehicle_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle = new Car("ABC123", "Red", 4, 5);
            garageHandler.ParkVehicle(vehicle);

            // Act
            garageHandler.RemoveVehicle("ABC123");

            // Assert
            Assert.DoesNotContain(vehicle, garageHandler.SearchVehicles(v => v != null));
        }

        [Fact]
        public void ListAllVehicles_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle1 = new Car("ABC123", "Red", 4, 5);
            var vehicle2 = new Motorcycle("DEF456", "Blue", 2, false);
            garageHandler.ParkVehicle(vehicle1);
            garageHandler.ParkVehicle(vehicle2);

            //Act
            var vehicleList = garageHandler.getAllVehicles();

            // Assert
            Assert.True(vehicleList.Length > 0);
            Assert.Equal("ABC123", vehicleList[0].RegistrationNumber);
        }

        [Fact]
        public void getVehicleTypes_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle1 = new Car("ABC123", "Red", 4, 5);
            var vehicle2 = new Motorcycle("DEF456", "Blue", 2, false);
            garageHandler.ParkVehicle(vehicle1);
            garageHandler.ParkVehicle(vehicle2);

            //Act
            var vehicleList = garageHandler.getVehicleTypes();

            //Assert
            Assert.True(vehicleList.ElementAt(0).FirstOrDefault() is Car);
            Assert.True(vehicleList.ElementAt(1).FirstOrDefault() is Motorcycle);

        }
    }
}
