using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BusTickets.BusinessServices.UnitTests.Services.Base
{
    internal class TestAsyncQueryProvider<T> : IAsyncQueryProvider
    {
        private readonly IQueryProvider queryProvider;

        internal TestAsyncQueryProvider(IQueryProvider queryProvider)
        {
            this.queryProvider = queryProvider;
        }

        public IQueryable CreateQuery(Expression expression)
            => new TestAsyncEnumerable<T>(expression);

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
            => new TestAsyncEnumerable<TElement>(expression);

        public object Execute(Expression expression)
            => this.queryProvider.Execute(expression);

        public TResult Execute<TResult>(Expression expression)
            => this.queryProvider.Execute<TResult>(expression);

        public IAsyncEnumerable<TResult> ExecuteAsync<TResult>(Expression expression)
            => new TestAsyncEnumerable<TResult>(expression);

        public Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken)
            => Task.FromResult(this.Execute<TResult>(expression));
    }
}
