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
            var journeyID = 5;
            var busStop = new[]
            {
                new BusStop { JourneyID = 73 },
                new BusStop { JourneyID = journeyID },
                new BusStop { JourneyID = 45 }
            };
            var dbSet = this.GetDbSetMock<BusStop>(busStop);
            this.ContextMock.Setup(s => s.BusStops).Returns(dbSet).Verifiable();

            // Act
            var service = new BusStopService(this.ContextMock.Object);
            var res = service.GetBusStop(journeyID);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(journeyID, res[0].JourneyID);
        }
    }
}
