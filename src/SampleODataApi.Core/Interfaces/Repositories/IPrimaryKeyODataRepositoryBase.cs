// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.AspNetCore.OData.Query;

namespace TsxCode.SampleODataApi.Core.Interfaces.Repositories
{
    /// <summary>
    ///     Defines a repository interface for aggregate root entities with a primary key that supports OData retrieval.
    /// </summary>
    /// <typeparam name="T">The type of aggregate root entity.</typeparam>
    public interface IPrimaryKeyODataRepositoryBase<T>
        where T : class, IAggregateRoot
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
    }
}
