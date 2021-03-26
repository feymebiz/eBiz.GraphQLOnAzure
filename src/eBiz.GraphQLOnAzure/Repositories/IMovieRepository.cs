using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiz.GraphQLOnAzure.Types;

namespace eBiz.GraphQLOnAzure.Repositories
{
	public interface IMovieRepository
	{
		Movie GetMovie(string title);
		IEnumerable<Movie> GetMovies(string title);
		Task<Movie> GetMovieAsync(string title);
		Task<IEnumerable<Movie>> GetMoviesAsync(string title);
		Movie GetMovieById(string id);
		Task<Movie> GetMovieByIdAsync(string id);
	}
}