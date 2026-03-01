// Copyright (c) 2026 Tomas Svejnoha. All rights reserved.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.ComponentModel;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Dtos;
using TsxCode.SampleODataApi.UseCases.Aggregates.CustomerAggregate.Queries.ListQuery;

namespace Restmium.SampleODataApi.Web.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class CustomersController : ODataController
    {
        [HttpGet]
        [EndpointName("Jobs_List")]
        [EndpointSummary("Retrieves a list of customers.")]
        public async Task<IActionResult> List(
            [FromQuery, Description("OData query options for the result set.")] ODataQueryOptions<CustomerDto> options,
            [FromServices] ListCustomersQueryHandler handler,
            CancellationToken cancellationToken)
        {
            ListCustomersQuery query = new()
            {
                Options = options,
            };

            IEnumerable<CustomerDto> result = await handler.Handle(query, cancellationToken);

            return Ok(result);
        }
    }
}
