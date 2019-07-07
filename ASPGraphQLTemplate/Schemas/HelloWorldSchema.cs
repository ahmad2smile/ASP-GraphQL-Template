using ASPGraphQLTemplate.Queries;
using GraphQL;
using GraphQL.Types;

namespace ASPGraphQLTemplate.Schemas
{
    public class HelloWorldSchema : Schema
    {
        public HelloWorldSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<HelloWorldQuery>();
        }
    }
}
