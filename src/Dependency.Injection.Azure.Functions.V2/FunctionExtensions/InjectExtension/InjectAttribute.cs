using System;
using Microsoft.Azure.WebJobs.Description;

namespace Dependency.Injection.Azure.Functions.V2
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class InjectAttribute : Attribute {}
}
