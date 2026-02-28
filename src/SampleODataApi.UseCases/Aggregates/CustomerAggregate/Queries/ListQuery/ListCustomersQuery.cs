using Microsoft.AspNetCore.OData.Query;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Dtos;

namespace TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Queries.ListQuery
{
    /// <summary>
    ///     Query for retrieving a list of customers with OData query support.
    /// </summary>
    /// <remarks>
    ///     The query allows applying OData options to refine the results, such as filtering,
    ///     sorting, and pagination parameters.
    /// </remarks>
    public sealed record ListCustomersQuery
    {
        /// <summary>
        ///     Gets the OData query options that define how customers should be filtered,
        ///     sorted, selected, expanded, and paged in the result set.
        /// </summary>
        public required ODataQueryOptions<CustomerDto> Options { get; init; }
    }
}
