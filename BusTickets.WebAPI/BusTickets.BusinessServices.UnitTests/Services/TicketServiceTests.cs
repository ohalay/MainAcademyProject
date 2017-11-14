using System.Threading.Tasks;
using BusTickets.BusinessServices.Services;
using BusTickets.BusinessServices.UnitTests.Services.Base;
using BusTickets.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class TicketServiceTests : BaseServiceTest
    {
        [TestMethod]
        public async Task GetTicket_WithJourneyId_ShouldFiltered()
        {
            // Arrange
            var jorneyId = 10;
            var ticket = new[]
            {
                new Ticket { JourneyID = 35 },
                new Ticket { JourneyID = jorneyId },
                new Ticket { JourneyID = 66 }
            };

            var dbSet = this.GetDbSetMock<Ticket>(ticket);
            this.ContextMock.Setup(s => s.Tickets).Returns(dbSet).Verifiable();

            // Act
            var service = new TicketService(this.ContextMock.Object);
            var res = await service.GetTicketAsync(jorneyId);

            // Assert
            this.ContextMock.Verify();
            Assert.IsNotNull(res);
            Assert.AreEqual(1, res);
            Assert.AreEqual(jorneyId, res);
        }
    }
}
