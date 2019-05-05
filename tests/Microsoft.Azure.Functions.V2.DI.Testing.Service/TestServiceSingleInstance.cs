using System;

namespace Microsoft.Azure.Functions.V2.DI.Testing.Service
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