using System;

namespace Dependency.Injection.Azure.Functions.V2.Testing.Service
{
    public class TestService : ITestService
    {
        private readonly IFunctionsContextResolver _contextResolver;
        private readonly ITestServiceSingleInstance _testSingleInstance;
        private readonly string _guidOnConstructor;
        private readonly IMockResolver _mockResolver;

        public TestService(
            IFunctionsContextResolver contextResolver, 
            ITestServiceSingleInstance testSingleInstance,
            IMockResolver mockResolver)
        {
            _contextResolver = contextResolver;
            _testSingleInstance = testSingleInstance;
            _guidOnConstructor = Guid.NewGuid().ToString();
            _mockResolver = mockResolver;
        }

        public string GetResult()
        {
            return
                $"ScopedFunctionId: {_contextResolver.FunctionContext.FunctionInstanceId} " + Environment.NewLine +
                $"TransientInstanceGuid: {_guidOnConstructor} " + Environment.NewLine +
                $"SingleInstanceGuid: {_testSingleInstance.GetSingleValue()}" + Environment.NewLine +
                $"IsMockEnabled: {_mockResolver.IsMockEnabled()}";
        }
    }
}
