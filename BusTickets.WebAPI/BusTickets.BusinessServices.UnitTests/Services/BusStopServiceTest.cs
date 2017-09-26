using BusTickets.BusinessServices.Services;
using BusTickets.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class BusStopServiceTest : BaseServiceTest
    {
        [TestMethod]
        public void GetBusStop_WithJorneyID_ShouldFiltered()
        {
            // Arrange
            var jorneyID = 5;
            var busStop = new[]
            {
                new BusStop { JorneyID = 73 },
                new BusStop { JorneyID = jorneyID },
                new BusStop { JorneyID = 45 }
            };
            var dbSet = this.GetDbSetMock<BusStop>(busStop);
            this.ContextMock.Setup(s => s.BusStops).Returns(dbSet).Verifiable();

            // Act
            var service = new BusStopService(this.ContextMock.Object);
            var res = service.GetBusStop(jorneyID);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(jorneyID, res[0].JorneyID);
        }
    }
}
