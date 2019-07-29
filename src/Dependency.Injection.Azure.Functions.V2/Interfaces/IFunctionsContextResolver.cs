using Dependency.Injection.Azure.Functions.V2.Models;

namespace Dependency.Injection.Azure.Functions.V2
{
    public partial interface IFunctionsContextResolver
    {
        FunctionContext FunctionContext { get; set; }
    }
} 