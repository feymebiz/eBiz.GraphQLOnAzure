using eBiz.GraphQLOnAzure.Repositories;
using eBiz.GraphQLOnAzure.Types;
using HotChocolate.AzureFunctionsProxy;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(eBiz.GraphQLOnAzure.Startup))]
namespace eBiz.GraphQLOnAzure
{
	public class Startup
		: FunctionsStartup
	{
		public override void Configure(IFunctionsHostBuilder builder)
		{
			var services = builder.Services;

			services.AddSingleton<IMovieRepository, MovieRepository>();

			services.AddGraphQLServer()
				.AddQueryType<QueryType>();

			services.AddAzureFunctionsGraphQL();
		}
	}
}
