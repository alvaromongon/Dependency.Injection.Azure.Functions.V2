[![Build Status](https://wtwd.visualstudio.com/Ease%20Maker/_apis/build/status/alvaromongon.Dependency.Injection.Azure.Functions.V2?branchName=master)](https://wtwd.visualstudio.com/Ease%20Maker/_build/latest?definitionId=4&branchName=master)

# Introduction 
Implementation of depency injection for Microsoft Azure Functions v2
Although dependency injection support will be added as part of the V2 functions plarform, in the meanwhile this is a good approach.

# Getting Started
- Install the package
- Register the injector "webJobsBuilder.AddInjectExtension();" and services 
- Use the [inject] attribute in your functions.

There is also support added to set the function in "mock" state using a header for http triggered functions, but this is not yet properly tested.

# Build and Test
I was using VS2019 to build the solution and there are a couple of projects that implement a function and some services to be injected.
So you can run the function locally and make some request to check how it works.
