using eBiz.GraphQLOnAzure.Repositories;
using HotChocolate;
using System.Collections.Generic;

namespace eBiz.GraphQLOnAzure.Types
{
	public class Query
	{
		private readonly IMovieRepository movieRepository;

		public Query([Service] IMovieRepository repository)
		{
			movieRepository = repository;
		}

		public Movie GetMovie(string title) => movieRepository.GetMovie(title);
		public IEnumerable<Movie> GetMovies(string title) => movieRepository.GetMovies(title);
		public Movie GetMovieById(string id) => movieRepository.GetMovieById(id);
	}
}
