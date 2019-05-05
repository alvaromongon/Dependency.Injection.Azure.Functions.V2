using System;
using Microsoft.Azure.WebJobs.Description;

namespace Microsoft.Azure.Functions.V2.DI
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute {}
}
