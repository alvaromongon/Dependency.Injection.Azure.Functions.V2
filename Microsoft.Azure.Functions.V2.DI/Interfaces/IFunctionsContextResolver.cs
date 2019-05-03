using Microsoft.Azure.Functions.V2.DI.Models;

namespace Microsoft.Azure.Functions.V2.DI
{
    public partial interface IFunctionsContextResolver
    {
        FunctionContext FunctionContext { get; set; }
    }
} 