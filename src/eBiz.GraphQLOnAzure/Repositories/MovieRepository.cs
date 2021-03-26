
using eBiz.GraphQLOnAzure.Types;
using IO.Swagger.Api;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiz.GraphQLOnAzure.Repositories
{
	public class MovieRepository : IMovieRepository
	{
		private const string ApiKey = "<YOUR_APIKEY>";
		public IEnumerable<Movie> GetMovies(string title)
		{
			var api = new SearchParameterApi();
			api.Configuration.AddApiKey("apikey", ApiKey);

			var result = Task.Run(() => api
			  .TitleSearchAsyncWithHttpInfo(title))
			  .Result;

			var searchResult = Newtonsoft.Json.JsonConvert
			  .DeserializeObject<SearchResult>(result.Data.ToString());
			return searchResult.Search;
		}

		public async Task<IEnumerable<Movie>> GetMoviesAsync(string title)
		{
			return await Task.Run(() => GetMovies(title));
		}

		public Movie GetMovie(string title)
		{
			var api = new TitleParameterApi();
			api.Configuration.AddApiKey("apikey", ApiKey);

			var result = Task.Run(() => api
			  .GetTitleWithHttpInfo(title))
			  .Result;

			var movie = Newtonsoft.Json.JsonConvert
			  .DeserializeObject<Movie>(result.Data.ToString());
			return movie;
		}

		public async Task<Movie> GetMovieAsync(string title)
		{
			return await Task.Run(() => GetMovie(title));
		}

		public Movie GetMovieById(string id)
		{
			var api = new IDParameterApi();
			api.Configuration.AddApiKey("apikey", ApiKey);

			var result = Task.Run(() => api
			  .GetIdWithHttpInfo(id))
			  .Result;

			var movie = Newtonsoft.Json.JsonConvert
			  .DeserializeObject<Movie>(result.Data.ToString());
			return movie;
		}

		public async Task<Movie> GetMovieByIdAsync(string id)
		{
			return await Task.Run(() => GetMovieById(id));
		}
	}
}
