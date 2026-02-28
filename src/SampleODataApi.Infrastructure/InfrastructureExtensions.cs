// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TsxCode.SampleODataApi.Core.Interfaces;
using TsxCode.SampleODataApi.Core.Interfaces.Repositories;
using TsxCode.SampleODataApi.Infrastructure.Database;
using TsxCode.SampleODataApi.Infrastructure.Database.Repositories;

namespace TsxCode.SampleODataApi.Infrastructure
{
    /// <summary>
    ///     Provides extension methods for configuring infrastructure services in the application.
    /// </summary>
    public static class InfrastructureExtensions
    {
        /// <summary>
        ///     Registers infrastructure services required by the application.
        /// </summary>
        /// <param name="builder">The host application builder to configure.</param>
        /// <returns>
        ///     The configured <paramref name="builder"/> for method chaining.
        /// </returns>
        public static IHostApplicationBuilder ConfigureInfrastructure(this IHostApplicationBuilder builder)
        {
            _ = builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            _ = builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

            return builder;
        }
    }
}
