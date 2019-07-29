#if NETSTANDARD2_0
using Microsoft.Azure.WebJobs.Host.Config;

namespace Dependency.Injection.Azure.Functions.V2
{
    internal class InjectConfiguration : IExtensionConfigProvider
    {
        private readonly InjectBindingProvider _bindingProvider;

        public InjectConfiguration(InjectBindingProvider bindingProvider) => _bindingProvider = bindingProvider;

        public void Initialize(ExtensionConfigContext context) => context
            .AddBindingRule<InjectAttribute>()
            .Bind(_bindingProvider);
    }
}
#endif