using ASPGraphQLTemplate.Models;
using ASPGraphQLTemplate.Types;
using GraphQL.Types;

namespace ASPGraphQLTemplate.Queries
{
    public class HelloWorldQuery : ObjectGraphType
    {
        public HelloWorldQuery()
        {
            Field<HelloWorldType>("hello", resolve: context => new HelloWorld
            {
                Message = "Hello World"
            });
        }
    }
}
