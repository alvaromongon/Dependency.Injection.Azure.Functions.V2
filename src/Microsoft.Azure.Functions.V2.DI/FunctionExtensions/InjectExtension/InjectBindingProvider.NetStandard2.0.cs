#if NETSTANDARD2_0
using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.V2.DI
{
    internal class InjectBindingProvider : IBindingProvider
    {
        public static readonly ConcurrentDictionary<Guid, IServiceScope> Scopes = new ConcurrentDictionary<Guid, IServiceScope>();

        private readonly IServiceProvider _serviceProvider;

        public InjectBindingProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task<IBinding> TryCreateAsync(BindingProviderContext context)
        {
            IBinding binding = new InjectBinding(_serviceProvider, context.Parameter.ParameterType);
            return Task.FromResult(binding);
        }
    }
}
#endif