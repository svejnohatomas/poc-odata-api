// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.OpenApi;
using Restmium.SampleODataApi.Web.Models.Customers.Responses;

namespace Restmium.SampleODataApi.Web
{
    internal static class WebExtensions
    {
        public static WebApplicationBuilder ConfigureWeb(this WebApplicationBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            _ = builder.ConfigureOData();
            _ = builder.ConfigureOpenApi();

            return builder;
        }

        private static WebApplicationBuilder ConfigureOData(this WebApplicationBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            ODataConventionModelBuilder modelBuilder = new();
            modelBuilder.EntitySet<CustomerResponseRecord>("Customers");
            IEdmModel edmModel = modelBuilder.GetEdmModel();

            builder.Services.AddControllers().AddOData(options => options.AddRouteComponents(edmModel));

            return builder;
        }

        private static WebApplicationBuilder ConfigureOpenApi(this WebApplicationBuilder builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            _ = builder.Services.AddOpenApi(options =>
            {
                options.OpenApiVersion = OpenApiSpecVersion.OpenApi3_1;

                _ = options.AddDocumentTransformer((document, context, cancellationToken) =>
                {
                    document.Info = new OpenApiInfo()
                    {
                        Title = "Sample OData API",
                        Contact = new()
                        {
                            Name = "Tomas Svejnoha",
                            Url = new Uri("https://github.com/svejnohatomas"),
                        },
                    };

                    return Task.CompletedTask;
                });
            });

             return builder;
        }
    }
}
