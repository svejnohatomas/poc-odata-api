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
        ///     Retrieves entities from the data store using OData query options.
        /// </summary>
        /// <param name="queryOptions">The OData query options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation. The task result contains the enumerable of entities.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
        Task<IEnumerable<T>> GetAllAsync(ODataQueryOptions<T> queryOptions, CancellationToken cancellationToken = default);

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
