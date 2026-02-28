// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.AspNetCore.OData.Query;

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a repository interface for aggregate root entities with a primary key that supports OData retrieval.
    /// </summary>
    /// <typeparam name="T">The type of aggregate root entity.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public interface IPrimaryKeyODataRepositoryBase<T, TKey> : IPrimaryKeyRepositoryBase<T, TKey>
        where T : class, IAggregateRoot
        where TKey : struct
    {
        /// <summary>
        ///     Returns an <see cref="IQueryable{T}"/> representing the queryable data source for this repository.
        /// </summary>
        /// <remarks>
        ///     This method provides direct access to the underlying <see cref="IQueryable{T}"/> without executing the query,
        ///     enabling further LINQ composition (e.g., Where, OrderBy, Select) that can be deferred until enumeration.
        ///     Use this for building efficient, server-side evaluable queries, especially in Domain-Driven Design or Clean Architecture patterns.
        /// </remarks>
        /// <returns>
        ///     An <see cref="IQueryable{T}"/> that can be further queried or enumerated.
        /// </returns>
        IQueryable<T> GetQueryable();

        /// <summary>
        ///     Returns the total count of entities of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation. The task result contains the total entity count.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
        Task<long> LongCountAsync(CancellationToken cancellationToken = default);
    }
}
