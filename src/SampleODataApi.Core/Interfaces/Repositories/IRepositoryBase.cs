// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a base repository interface for aggregate root entities, providing basic CRUD operations.
    /// </summary>
    /// <typeparam name="T">The type of aggregate root entity.</typeparam>
    public interface IRepositoryBase<T> where T : IAggregateRoot
    {
        /// <summary>
        ///     Asynchronously adds a new entity to the repository.
        /// </summary>
        /// <param name="item">The entity to add.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A task that represents the asynchronous operation. The task result contains the added entity.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken" /> is canceled.</exception>
        Task<T> AddAsync(T item, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Deletes the specified entity from the repository.
        /// </summary>
        /// <param name="item">The entity to delete.</param>
        void Delete(T item);

        /// <summary>
        ///     Updates the specified entity in the repository.
        /// </summary>
        /// <param name="item">The entity to update.</param>
        /// <returns>The updated entity.</returns>
        T Update(T item);
    }
}
