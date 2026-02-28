// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;
using TsxCode.SampleODataApi.Core.Aggregates.OrderAggregate;
using TsxCode.SampleODataApi.Core.Interfaces.Repositories;

namespace TsxCode.SampleODataApi.Core.Interfaces
{
    /// <summary>
    ///     Defines the unit of work contract for coordinating repository operations.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        ///     Gets the repository for accessing and managing <see cref="Customer"/> entities.
        /// </summary>
        ICustomerRepository CustomerRepository { get; }

        /// <summary>
        ///     Gets the repository for accessing and managing <see cref="Order"/> entities.
        /// </summary>
        IOrderRepository OrderRepository { get; }

        /// <summary>
        ///     Determines whether or not the database is available and can be connected to.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A <see cref="Task"/> that represents the asynchronous operation.
        ///     The task result is <see langword="true"/> if the database can be connected to; otherwise, <see langword="false"/>.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken"/> is canceled.</exception>
        Task<bool> CanConnectAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///     Saves all changes made in the current unit of work asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        ///     A <see cref="Task"/> that represents the asynchronous save operation.
        ///     The task result contains the number of state entries written to the underlying database.
        /// </returns>
        /// <exception cref="OperationCanceledException">If the <see cref="CancellationToken"/> is canceled.</exception>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
