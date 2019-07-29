using Dependency.Injection.Azure.Functions.V2.Testing.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace Dependency.Injection.Azure.Functions.V2.Testing.AFV2
{
    public static class AzureFunctionV2
    {
        [FunctionName(nameof(AzureFunctionV2))]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")]
            HttpRequestMessage httpRequestMessage,
            ILogger log,
            [Inject] ITestService testService)
        {
            return httpRequestMessage.CreateResponse(testService.GetResult());
        }
    }
}
