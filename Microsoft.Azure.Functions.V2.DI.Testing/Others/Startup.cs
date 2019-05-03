using Microsoft.Azure.Functions.V2.DI.Extensions;
using Microsoft.Azure.Functions.V2.DI.Testing.AFV2.Others;
using Microsoft.Azure.Functions.V2.DI.Testing.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(Startup))]
namespace Microsoft.Azure.Functions.V2.DI.Testing.AFV2.Others
{
    internal class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder webJobsBuilder)
        {
            webJobsBuilder.AddInjectExtension();

            webJobsBuilder.Services
                .AddTransient<ITestService, TestService>()
                .AddSingleton<ITestServiceSingleInstance, TestServiceSingleInstance>();
        }
    }
}
