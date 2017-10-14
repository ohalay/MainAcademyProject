using System.Threading.Tasks;
using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class CityNearbyServiceTests : BaseServiceTest
    {
        [TestMethod]
        public async Task GetCitiseNearby_WithCityId_ShouldFiltered()
        {
            // Arrange
            var cityId = 10;
            var citiesNaearby = new[]
            {
                new CitiesNearby { CityID = 35 },
                new CitiesNearby { CityID = cityId },
                new CitiesNearby { CityID = 66 }
            };

            var dbSet = this.GetDbSetMock<CitiesNearby>(citiesNaearby);
            this.ContextMock.Setup(s => s.CitiesNearbys).Returns(dbSet).Verifiable();

            // Act
            var service = new CityNearbyService(this.ContextMock.Object);
            var resAsync = await service.GetCitiseNearbyAsync(cityId);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(resAsync);
            Assert.AreEqual(1, resAsync.Count);
            Assert.AreEqual(cityId, resAsync[1]);
        }
    }
}
