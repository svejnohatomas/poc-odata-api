using TsxCode.SampleODataApi.Core.Aggregates.CustomerAggregate;
using TsxCode.SampleODataApi.Core.Interfaces.Repositories;

namespace TsxCode.SampleODataApi.Infrastructure.Database.Repositories
{
    internal sealed class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {
            for (int i = 1; i <= 10; i++)
            {
                _customers.Add(new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = $"Customer {i}",
                });
            }
        }

        private readonly List<Customer> _customers = [];

        public IQueryable<Customer> GetQueryable()
        {
            return _customers.AsQueryable();
        }
    }
}
