// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using System.ComponentModel;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Dtos;

namespace Restmium.SampleODataApi.Web.Models.Customers.Responses
{
    [Description("Represents a response model for a customer.")]
    public sealed record CustomerResponseRecord
    {
        [Description("The unique identifier of the customer.")]
        public required Guid? Id { get; init; }

        [Description("The name of the customer.")]
        public required string? Name { get; init; }

        internal static CustomerResponseRecord From(CustomerDto customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            return new()
            {
                Id = customer.Id,
                Name = customer.Name,
            };
        }
    }
}
