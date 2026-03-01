// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a repository for accessing and managing <see cref="Customer"/> entities.
    /// </summary>
    /// <remarks>
    ///     Inherits standard CRUD and primary key-based OData operations for customers.
    /// </remarks>
    public interface ICustomerRepository : IPrimaryKeyODataRepositoryBase<Customer>;
}
