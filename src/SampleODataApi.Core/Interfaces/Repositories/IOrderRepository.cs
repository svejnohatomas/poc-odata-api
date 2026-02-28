// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Aggregates.OrderAggregate;

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a repository for accessing and managing <see cref="Order"/> entities.
    /// </summary>
    /// <remarks>
    ///     Inherits standard CRUD and primary key-based OData operations for orders.
    /// </remarks>
    public interface IOrderRepository : IPrimaryKeyODataRepositoryBase<Order, Guid>;
}
