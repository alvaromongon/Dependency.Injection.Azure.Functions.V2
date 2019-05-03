using Microsoft.Azure.Functions.V2.DI.Models;

namespace Microsoft.Azure.Functions.V2.DI
{
    public partial class FunctionsContextResolver : IFunctionsContextResolver
    {
        public FunctionContext FunctionContext { get; set; }
    }
} 