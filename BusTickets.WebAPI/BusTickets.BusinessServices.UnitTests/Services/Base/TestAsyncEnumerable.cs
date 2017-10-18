using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusTickets.BusinessServices.UnitTests.Services.Base
{
    internal class TestAsyncEnumerable<T> : EnumerableQuery<T>, IAsyncEnumerable<T>, IQueryable<T>
    {
        internal TestAsyncEnumerable(IEnumerable<T> enumerable)
            : base(enumerable)
        {
        }

        internal TestAsyncEnumerable(Expression expression)
            : base(expression)
        {
        }

        public IAsyncEnumerator<T> GetEnumerator()
            => new TestAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());

#pragma warning disable SA1201 // Elements must appear in the correct order
        IQueryProvider IQueryable.Provider => new TestAsyncQueryProvider<T>(this);
#pragma warning restore SA1201 // Elements must appear in the correct order
    }
}
