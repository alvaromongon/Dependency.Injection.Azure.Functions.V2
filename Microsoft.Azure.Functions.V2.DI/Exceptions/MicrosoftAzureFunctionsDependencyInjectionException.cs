using System;

namespace Microsoft.Azure.Functions.V2.DI.Exceptions
{
    internal class MicrosoftAzureFunctionsDependencyInjectionException : Exception
    {
        public MicrosoftAzureFunctionsDependencyInjectionException(string message) : base(message) { }
    }
}
