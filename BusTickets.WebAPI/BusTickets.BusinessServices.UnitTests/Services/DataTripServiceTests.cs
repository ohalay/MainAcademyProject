namespace BusTickets.BusinessServices.UnitTests.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BusTickets.BusinessServices.Services;
    using BusTickets.DataAccess;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DataTripServiceTests : BaseServiceTest
    {
        [TestMethod]
        public void GetTrips_WithDate_ShouldFiltered()
        {
            // Arrange
            var dateFrom = new DateTime(2017, 10, 01);
            var dateTo = new DateTime(2017, 09, 30);
            var listJourney = new List<Journey>()
            {
                new Journey { DepartureTime = dateFrom },
                new Journey { DepartureTime = dateTo },
                new Journey { DepartureTime = new DateTime(2017, 10, 01) },
                new Journey { DepartureTime = new DateTime(2017, 10, 09) },
                new Journey { DepartureTime = new DateTime(2017, 11, 02) }
            };

            var dbSet = this.GetDbSetMock<Journey>(listJourney);
            this.ContextMock.Setup(s => s.Journeys).Returns(dbSet).Verifiable();

            // Act
            var service = new DataTripService(this.ContextMock.Object);
            var res = service.GetJourneyByDate(dateTo, dateFrom);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res.Count);
            Assert.AreEqual(dateFrom, res[0].DepartureTime);
        }
    }
}
