using Microsoft.Azure.Functions.V2.DI.Filters;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.V2.DI.Extensions
{
    public static class WebJobsBuilderExtensions
    {
        public static void AddInjectExtension(this IWebJobsBuilder webJobsBuilder)
        {
            webJobsBuilder.Services
                .AddSingleton<IFunctionInvocationFilter, ScopeCleanupFilter>()
                .AddSingleton<IFunctionExceptionFilter, ScopeCleanupFilter>()
                .AddScoped<IFunctionsContextResolver, FunctionsContextResolver>()
                .AddScoped<IMockResolver, MockResolver>()
                .AddTransient<InjectBindingProvider>();

            webJobsBuilder.AddExtension(typeof(InjectConfiguration));
        }
    }
} 