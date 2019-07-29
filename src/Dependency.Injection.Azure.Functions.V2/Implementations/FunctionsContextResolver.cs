using Dependency.Injection.Azure.Functions.V2.Models;

namespace Dependency.Injection.Azure.Functions.V2
{
    public partial class FunctionsContextResolver : IFunctionsContextResolver
    {
        public FunctionContext FunctionContext { get; set; }
    }
} 