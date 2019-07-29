using Dependency.Injection.Azure.Functions.V2.Extensions;
using Dependency.Injection.Azure.Functions.V2.Testing.AFV2.Others;
using Dependency.Injection.Azure.Functions.V2.Testing.Service;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: WebJobsStartup(typeof(Startup))]
namespace Dependency.Injection.Azure.Functions.V2.Testing.AFV2.Others
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
