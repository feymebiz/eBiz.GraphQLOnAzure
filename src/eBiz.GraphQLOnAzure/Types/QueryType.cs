using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBiz.GraphQLOnAzure.Types
{
	public class QueryType
		: ObjectType<Query>
	{
		protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
		{
			descriptor.Field(t => t.GetMovie(default))
				.Type<MovieType>();

			descriptor.Field(t => t.GetMovies(default))
				.Type<ListType<MovieType>>();

			descriptor.Field(t => t.GetMovieById(default))
				.Type<MovieType>();
		}
	}
}
