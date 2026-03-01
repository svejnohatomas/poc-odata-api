// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;
using TsxCode.SampleODataApi.Core.Interfaces;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Dtos;

namespace TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Queries.ListQuery
{
    /// <summary>
    ///     Handles the <see cref="ListCustomersQuery"/> to retrieve a list of customers asynchronously.
    /// </summary>
    /// <param name="unitOfWork">The unit of work providing access to the customer repository.</param>
    internal sealed class ListCustomersQueryHandler(IUnitOfWork unitOfWork)
    {
        /// <summary>
        ///     Executes the query to fetch customers and maps them to DTOs.
        /// </summary>
        /// <param name="request">The query request containing any filtering or pagination parameters.</param>
        /// <param name="cancellationToken">Token to cancel the operation if needed.</param>
        /// <returns>
        ///     A task containing the list of <see cref="CustomerDto"/>.
        /// </returns>
        public Task<IEnumerable<CustomerDto>> Handle(ListCustomersQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ArgumentNullException.ThrowIfNull(request);

            IQueryable<Customer> query = unitOfWork.CustomerRepository.GetQueryable();

            IEnumerable<CustomerDto> result = query.Select(CustomerDto.From);

            return Task.FromResult(result);
        }
    }
}
