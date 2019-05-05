using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.V2.DI.Models
{
    public class FunctionContext
    {
        public string FunctionInstanceId { get; set; }
        public FunctionRequest FunctionRequest { get; set; }
        public IServiceScope CurrentScope { get; set; }
    }
} 