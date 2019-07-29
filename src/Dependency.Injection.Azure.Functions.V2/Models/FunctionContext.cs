using Microsoft.Extensions.DependencyInjection;

namespace Dependency.Injection.Azure.Functions.V2.Models
{
    public class FunctionContext
    {
        public string FunctionInstanceId { get; set; }
        public FunctionRequest FunctionRequest { get; set; }
        public IServiceScope CurrentScope { get; set; }
    }
} 