using Ardalis.GuardClauses;
using TsxCode.SampleODataApi.Core.Interfaces;

namespace TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate
{

    /// <summary>
    ///     Represents a customer who places orders.
    /// </summary>
    public class Customer : IAggregateRoot
    {
        /// <summary>
        ///     Gets or sets the unique identifier for the customer.
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the customer's full name.
        /// </summary>
        public required string Name { get; set; }
    }
}
