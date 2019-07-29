using System;

namespace Dependency.Injection.Azure.Functions.V2.Exceptions
{
    internal class MicrosoftAzureFunctionsDependencyInjectionException : Exception
    {
        public MicrosoftAzureFunctionsDependencyInjectionException(string message) : base(message) { }
    }
}
