// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Queries.ListQuery;

namespace TsxCode.SampleODataApi.UseCases
{
    /// <summary>
    ///     Provides extension methods for configuring use case services in the application.
    /// </summary>
    public static class UseCasesExtensions
    {
        /// <summary>
        ///     Registers use cases services required by the application.
        /// </summary>
        /// <param name="builder">The host application builder to configure.</param>
        /// <returns>
        ///     The configured <paramref name="builder"/> for method chaining.
        /// </returns>
        public static IHostApplicationBuilder ConfigureUseCases(this IHostApplicationBuilder builder)
        {
            _ = builder.Services.AddScoped<ListCustomersQueryHandler>();

            return builder;
        }
    }
}
