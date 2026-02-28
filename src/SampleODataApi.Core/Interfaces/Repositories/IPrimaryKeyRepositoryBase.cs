// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a repository interface for aggregate root entities with a primary key.
    /// </summary>
    /// <typeparam name="T">The type of aggregate root entity.</typeparam>
    /// <typeparam name="TKey">The type of the primary key.</typeparam>
    public interface IPrimaryKeyRepositoryBase<T, TKey> : IRepositoryBase<T>
        where T : class, IAggregateRoot
        where TKey : struct
    {
        /// <summary>
        ///     Retrieves an entity by its primary key identifier.
        /// </summary>
        /// <param name="id">The value representing the primary key.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation. The task result contains the entity
        ///     if found; otherwise, <see langword="null"/>.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
        Task<T?> GetByIdAsync(TKey id, CancellationToken cancellationToken = default);
    }
}
