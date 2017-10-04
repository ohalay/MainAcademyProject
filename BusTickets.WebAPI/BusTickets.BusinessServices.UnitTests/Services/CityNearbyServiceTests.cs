using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class CityNearbyServiceTests : BaseServiceTest
    {
        [TestMethod]
        public void GetCitiseNearby_WithCityId_ShouldFiltered()
        {
            // Arrange
            var cityId = 10;
            var citiesNaearby = new[]
            {
                new Ticket { JourneyID = 35 },
                new Ticket { JourneyID = cityId },
                new Ticket { JourneyID = 66 }
            };

            var dbSet = this.GetDbSetMock<Ticket>(citiesNaearby);
            this.ContextMock.Setup(s => s.CitiesNearbys).Returns(dbSet).Verifiable();

            // Act
            var service = new CityNearbyService(this.ContextMock.Object);
            var res = service.GetCitiseNearby(cityId);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(cityId, res[0].JourneyID);
        }
    }
}
