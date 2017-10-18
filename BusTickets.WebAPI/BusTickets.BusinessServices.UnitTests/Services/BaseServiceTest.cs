using System.Collections.Generic;
using System.Linq;
using BusTickets.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusTickets.BusinessServices.UnitTests.Services
{
    [TestClass]
    public class BaseServiceTest
    {
        private Mock<IBusTicketDbContext> contextMock;

        protected Mock<IBusTicketDbContext> ContextMock => this.contextMock;

        [TestInitialize]
        public void Initialize()
        {
            this.contextMock = new Mock<IBusTicketDbContext>();
        }

        public DbSet<T> GetDbSetMock<T>(IList<T> sourceList)
            where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbset = new Mock<DbSet<T>>(MockBehavior.Loose);
            dbset.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbset.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbset.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbset.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbset.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => sourceList.Add(s));
            dbset.Setup(m => m.Remove(It.IsAny<T>())).Callback<T>((m) => sourceList.Remove(m));
            dbset.Setup(m => m.RemoveRange(It.IsAny<IEnumerable<T>>())).Callback<IEnumerable<T>>((m) =>
            {
                var collection = m as List<T> ?? m.ToList();
                foreach (var item in collection)
                {
                    sourceList.Remove(item);
                }
            });

            return dbset.Object;
        }
    }
}
