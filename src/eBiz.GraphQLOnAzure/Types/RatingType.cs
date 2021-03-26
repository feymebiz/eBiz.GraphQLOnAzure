using HotChocolate.Types;

namespace eBiz.GraphQLOnAzure.Types
{
	public class RatingType
		: ObjectType<Rating>
	{
		protected override void Configure(IObjectTypeDescriptor<Rating> descriptor)
		{
			descriptor.Field(t => t.Source)
				.Type<StringType>();

			descriptor.Field(t => t.Value)
				.Type<StringType>();
		}
	}
}
