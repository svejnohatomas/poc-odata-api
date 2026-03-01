using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;
using TsxCode.SampleODataApi.Core.Interfaces.Repositories;

namespace TsxCode.SampleODataApi.Infrastructure.Database.Repositories
{
    internal sealed class CustomerRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Customer A",
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Customer B",
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Customer C",
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Customer D",
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Customer E",
            },
        ];

        public IQueryable<Customer> GetQueryable()
        {
            return _customers.AsQueryable();
        }
    }
}
