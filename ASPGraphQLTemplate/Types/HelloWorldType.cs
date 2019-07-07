using ASPGraphQLTemplate.Models;
using GraphQL.Types;

namespace ASPGraphQLTemplate.Types
{
    public class HelloWorldType : ObjectGraphType<HelloWorld>
    {
        public HelloWorldType()
        {
            Field(p => p.Message).Description("Message associate with HelloWorld");
        }
    }
}
