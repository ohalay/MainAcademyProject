using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace BusTickets.BusinessServices.UnitTests
{
    public class BaseServiceTest
    {
        public DbSet<T> GetDbSetMock<T>(IList<T> sourceList)
            where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbset = new Mock<DbSet<T>>(MockBehavior.Loose);
            dbset.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbset.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbset.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbset.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbset.Setup(m => m.AsNoTracking()).Returns(dbset.Object);
            dbset.Setup(d => d.Include(It.IsAny<string>())).Returns(dbset.Object);
            dbset.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => sourceList.Add(s));
            dbset.Setup(m => m.Remove(It.IsAny<T>())).Callback<T>((m) => sourceList.Remove(m));
            dbset.Setup(m => m.Include(It.IsAny<string>())).Returns(dbset.Object);
            dbset.Setup(d => d.AddRange(It.IsAny<IEnumerable<T>>())).Callback<IEnumerable<T>>((s) =>
            {
                var collection = s as List<T> ?? s.ToList();
                foreach (var item in collection)
                {
                    sourceList.Add(item);
                }
            });
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
