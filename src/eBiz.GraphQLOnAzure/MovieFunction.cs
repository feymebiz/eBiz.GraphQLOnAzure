using HotChocolate.AzureFunctionsProxy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace eBiz.GraphQLOnAzure
{
	public class MovieFunction
	{
		private readonly IGraphQLAzureFunctionsExecutorProxy _proxy;

		public MovieFunction(IGraphQLAzureFunctionsExecutorProxy proxy)
		{
			_proxy = proxy;
		}

		[FunctionName(nameof(MovieFunction))]
		public async Task<IActionResult> Run(
			 [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "graphql")] HttpRequest req,
			 ILogger log,
			 CancellationToken cancellationToken)
		{
			return await _proxy.ExecuteFunctionsQueryAsync(
				req.HttpContext,
				log,
				cancellationToken)
				.ConfigureAwait(false);
		}
	}
}
