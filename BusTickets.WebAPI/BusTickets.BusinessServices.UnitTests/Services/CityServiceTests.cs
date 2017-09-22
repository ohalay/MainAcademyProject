using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class CityServiceTests : BaseServiceTest
    {
        [TestMethod]
        public void GetCitiseNearby_WithCityId_ShouldFiltered()
        {
            // Arrange
            var cityId = 10;
            var citiesNaearby = new[]
            {
                new CityNearby { CityID = 35 },
                new CityNearby { CityID = cityId },
                new CityNearby { CityID = 66 }
            };

            var dbSet = this.GetDbSetMock<CityNearby>(citiesNaearby);
            this.ContextMock.Setup(s => s.CitiesNearby).Returns(dbSet).Verifiable();

            // Act
            var service = new CityService(this.ContextMock.Object);
            var res = service.GetCitiseNearby(cityId);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(cityId, res[0].CityID);
        }
    }
}
