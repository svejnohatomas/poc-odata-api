// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Interfaces;

namespace TsxCode.SampleODataApi.Core.Aggregates.OrderAggregate
{
    /// <summary>
    ///     Represents an order placed by a customer.
    /// </summary>
    public class Order : IAggregateRoot
    {
        /// <summary>
        ///     Gets or sets the unique identifier for the order.
        /// </summary>
        public required Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the total monetary amount of the order.
        /// </summary>
        public required decimal Amount { get; set; }
    }
}
