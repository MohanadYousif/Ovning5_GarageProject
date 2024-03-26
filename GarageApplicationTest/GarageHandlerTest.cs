using GarageApplication.Controllers;

namespace GarageApplication.Test
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
        public void getAllVehicles_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle1 = new Car("ABC123", "Red", 4, 5);
            var vehicle2 = new Motorcycle("DEF456", "Blue", 2, false);
            garageHandler.ParkVehicle(vehicle1);
            garageHandler.ParkVehicle(vehicle2);

            //Act
            var vehicleList = garageHandler.GetAllVehicles();

            // Assert
            Assert.True(vehicleList.Length > 0);
            Assert.Equal("ABC123", vehicleList[0].RegistrationNumber);
            Assert.Equal("Blue", vehicleList.ElementAt(1).Color);
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
        public void getVehicleTypes_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(5);
            var vehicle1 = new Car("ABC123", "Red", 4, 5);
            var vehicle2 = new Motorcycle("DEF456", "Blue", 2, false);
            garageHandler.ParkVehicle(vehicle1);
            garageHandler.ParkVehicle(vehicle2);

            //Act
            var vehicleList = garageHandler.GetVehicleTypes();

            //Assert
            Assert.True(vehicleList.ElementAt(0).FirstOrDefault() is Car);
            Assert.True(vehicleList.ElementAt(1).FirstOrDefault() is Motorcycle);

        }

        [Fact]
        public void GetVehiclesByRegNumber_Success()
        {
            // Arrange
            var garageHandler = new GarageHandler(2);
            var vehicle1 = new Car("ABC123", "Red", 4, 5);
            var vehicle2 = new Motorcycle("DEF456", "Blue", 2, false);
            garageHandler.ParkVehicle(vehicle1);
            garageHandler.ParkVehicle(vehicle2);

            //Act
            var vehicle = garageHandler.GetVehiclesByRegNumber("aBc123");

            //Assert
            Assert.Equal("ABC123", vehicle.RegistrationNumber);
            Assert.Equal(4, vehicle.NumberOfWheels);
            Assert.True(vehicle is Car);

        }
    }
}
