// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Restmium.SampleODataApi.Web;
using TsxCode.SampleODataApi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.ConfigureWeb()
    .ConfigureInfrastructure();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
