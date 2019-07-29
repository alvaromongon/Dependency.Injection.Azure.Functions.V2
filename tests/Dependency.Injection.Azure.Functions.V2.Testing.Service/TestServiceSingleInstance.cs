using System;

namespace Dependency.Injection.Azure.Functions.V2.Testing.Service
{
    public class TestServiceSingleInstance : ITestServiceSingleInstance
    {
        private readonly string _singleInstanceValue;
        public TestServiceSingleInstance()
        {
            _singleInstanceValue = Guid.NewGuid().ToString();
        }
        public string GetSingleValue() => _singleInstanceValue;
    }
}