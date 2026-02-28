// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;

namespace TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Dtos
{
    /// <summary>
    ///     DTO for customer type.
    /// </summary>
    public sealed record CustomerDto
    {
        /// <summary>
        ///     The unique identifier for the customer.
        /// </summary>
        public required Guid Id { get; init; }

        /// <summary>
        ///     The customer name.
        /// </summary>
        public required string Name { get; init; }

        internal static CustomerDto From(Customer customer)
        {
            return new()
            {
                Id = customer.Id,
                Name = customer.Name,
            };
        }
    }
}
