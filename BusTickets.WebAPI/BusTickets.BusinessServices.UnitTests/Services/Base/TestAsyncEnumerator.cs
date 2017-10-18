using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BusTickets.BusinessServices.UnitTests.Services.Base
{
    internal class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> enumerator;

        internal TestAsyncEnumerator(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
        }

        public T Current => this.enumerator.Current;

        public void Dispose() => this.enumerator.Dispose();

        public Task<bool> MoveNext(CancellationToken cancellationToken)
            => Task.FromResult(this.enumerator.MoveNext());
    }
}
