using System;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.V2.DI.Exceptions;
using Microsoft.Azure.Functions.V2.DI.Models;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Azure.WebJobs.Host.Protocols;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Azure.Functions.V2.DI
{
    internal partial class InjectBinding : IBinding
    {
        private readonly Type _type;
        private readonly IServiceProvider _serviceProvider;

        internal InjectBinding(IServiceProvider serviceProvider, Type type)
        {
            _type = type;
            _serviceProvider = serviceProvider;
        }

        public bool FromAttribute => true;

        public Task<IValueProvider> BindAsync(object value, ValueBindingContext context) =>
            Task.FromResult((IValueProvider)new InjectValueProvider(value));

        public async Task<IValueProvider> BindAsync(BindingContext context)
        {
            await Task.Yield();
            var scope = InjectBindingProvider.Scopes.GetOrAdd(context.FunctionInstanceId, (_) => _serviceProvider.CreateScope());

            var functionsContextResolver = scope.ServiceProvider.GetService<IFunctionsContextResolver>();

            if (functionsContextResolver == null) throw new MicrosoftAzureFunctionsDependencyInjectionException(
                $"You must register '{nameof(IFunctionsContextResolver)}'. " +
                $"You can use '{nameof(FunctionsContextResolver)}' from this package.'");

            functionsContextResolver.FunctionContext = new FunctionContext
            {
                FunctionInstanceId = context.FunctionInstanceId.ToString(),
                CurrentScope = scope,
                FunctionRequest = GetFunctionRequest(context)
            };

            var value = scope.ServiceProvider.GetRequiredService(_type);
            return await BindAsync(value, context.ValueContext);
        }

        public ParameterDescriptor ToParameterDescriptor() => new ParameterDescriptor();

        private class InjectValueProvider : IValueProvider
        {
            private readonly object _value;

            public InjectValueProvider(object value) => _value = value;

            public Type Type => _value.GetType();

            public Task<object> GetValueAsync() => Task.FromResult(_value);

            public string ToInvokeString() => _value.ToString();
        }
    }
} 
