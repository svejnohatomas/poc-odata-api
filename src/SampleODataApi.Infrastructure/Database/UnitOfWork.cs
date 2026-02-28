// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using TsxCode.SampleODataApi.Core.Interfaces;
using TsxCode.SampleODataApi.Core.Interfaces.Repositories;

namespace TsxCode.SampleODataApi.Infrastructure.Database
{
    internal sealed class UnitOfWork : IUnitOfWork
    {
        public ICustomerRepository CustomerRepository => throw new NotImplementedException();

        public Task<bool> CanConnectAsync(CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return Task.FromResult(true);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return Task.FromResult(0);
        }
    }
}
