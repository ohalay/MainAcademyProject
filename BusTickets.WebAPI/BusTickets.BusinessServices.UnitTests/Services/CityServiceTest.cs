using System.Threading.Tasks;
using BusTickets.BusinessServices.Services;
using BusTickets.BusinessServices.UnitTests.Services.Base;
using BusTickets.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class CityServiceTest : BaseServiceTest
    {
        [TestMethod]
        public async Task GetCity_WithTheSameFirstLeter_ShouldFiltered()
        {
            ////arrange
            var city1 = "Lviv";
            var city2 = "London";
            var city = new[]
            {
                new City { Name = city1 },
                new City { Name = city2 },
                new City { Name = "Madrid" },
                new City { Name = "Milan" },
                new City { Name = "12lds" }
            };
            var dbSet = this.GetDbSetMock<City>(city);
            this.ContextMock.Setup(s => s.Cities).Returns(dbSet).Verifiable();

            //// Act
            var service = new CityService(this.ContextMock.Object);
            var res = await service.GetCityAsync("L");

            ////Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(2, res.Count);
            Assert.AreEqual(city1, "Lviv", city2, "London");
        }
    }
}
