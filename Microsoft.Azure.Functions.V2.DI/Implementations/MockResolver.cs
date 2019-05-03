using System.Linq;

namespace Microsoft.Azure.Functions.V2.DI
{
    public class MockResolver : IMockResolver
    {
        private readonly IFunctionsContextResolver _functionsContextResolver;

        public MockResolver(IFunctionsContextResolver functionsContextResolver)
        {
            _functionsContextResolver = functionsContextResolver;
        }

        public bool IsMockEnabled()
        {
            var headers = _functionsContextResolver.FunctionContext?.FunctionRequest?.Headers?.ToList();

            if (headers == null) return false;

            var mockHeader = headers.FirstOrDefault(x=> x.Key == "X-Mocking-Services").Value?.FirstOrDefault(f=> f == "Enabled") ??
                             headers.FirstOrDefault(x => x.Key == "X-MOCK").Value?.FirstOrDefault(f => f == "Enabled");

            return mockHeader != null;
        }
    }
} 
