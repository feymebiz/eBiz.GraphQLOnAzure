using HotChocolate.Types;

namespace eBiz.GraphQLOnAzure.Types
{
  public class MovieType
    : ObjectType<Movie>
  {
    protected override void Configure(IObjectTypeDescriptor<Movie> descriptor)
    {
      descriptor.Field(t => t.Title)
        .Type<StringType>();
      descriptor.Field(t => t.Year)
        .Type<StringType>();
      descriptor.Field(t => t.Actors)
        .Type<StringType>();
      descriptor.Field(t => t.Awards)
        .Type<StringType>();
      descriptor.Field(t => t.BoxOffice)
        .Type<StringType>();
      descriptor.Field(t => t.Country)
        .Type<StringType>();
      descriptor.Field(t => t.Director)
        .Type<StringType>();
      descriptor.Field(t => t.DVD)
        .Type<StringType>();
      descriptor.Field(t => t.Genre)
        .Type<StringType>();
      descriptor.Field(t => t.imdbID)
        .Type<StringType>();
      descriptor.Field(t => t.imdbRating)
        .Type<StringType>();
      descriptor.Field(t => t.imdbVotes)
        .Type<StringType>();
      descriptor.Field(t => t.Language)
        .Type<StringType>();
      descriptor.Field(t => t.Metascore)
        .Type<StringType>();
      descriptor.Field(t => t.Plot)
        .Type<StringType>();
      descriptor.Field(t => t.Poster)
        .Type<StringType>();
      descriptor.Field(t => t.Production)
        .Type<StringType>();
      descriptor.Field(t => t.Rated)
        .Type<StringType>();
      descriptor.Field(t => t.Released)
        .Type<StringType>();
      descriptor.Field(t => t.Response)
        .Type<StringType>();
      descriptor.Field(t => t.Runtime)
        .Type<StringType>();
      descriptor.Field(t => t.Type)
        .Type<StringType>();
      descriptor.Field(t => t.Website)
        .Type<StringType>();
      descriptor.Field(t => t.Writer)
        .Type<StringType>();
      descriptor.Field(t => t.Ratings)
        .Type<ListType<RatingType>>();
    }
  }
}
