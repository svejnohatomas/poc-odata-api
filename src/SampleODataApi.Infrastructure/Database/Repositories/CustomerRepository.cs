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

        public Task<Customer> AddAsync(Customer item, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            item.Id = Guid.NewGuid();
            _customers.Add(item);

            return Task.FromResult(item);
        }

        public void Delete(Customer item)
        {
            _customers.Remove(item);
        }

        public Task<Customer?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return Task.FromResult(_customers.SingleOrDefault(x => x.Id == id));
        }

        public IQueryable<Customer> GetQueryable()
        {
            return _customers.AsQueryable();
        }

        public Task<long> LongCountAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(_customers.LongCount());
        }

        public Customer Update(Customer item)
        {
            return item;
        }
    }
}
