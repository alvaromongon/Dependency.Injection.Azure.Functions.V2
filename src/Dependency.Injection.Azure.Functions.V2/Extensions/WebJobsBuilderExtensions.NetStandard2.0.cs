using Dependency.Injection.Azure.Functions.V2.Filters;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.DependencyInjection;

namespace Dependency.Injection.Azure.Functions.V2.Extensions
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