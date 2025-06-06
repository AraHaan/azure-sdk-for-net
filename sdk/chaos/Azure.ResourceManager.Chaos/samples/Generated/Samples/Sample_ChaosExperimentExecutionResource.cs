// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Chaos.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Chaos.Samples
{
    public partial class Sample_ChaosExperimentExecutionResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetTheExecutionOfAExperiment()
        {
            // Generated from example definition: 2025-01-01/Experiments_GetExecution.json
            // this example is just showing the usage of "ExperimentExecution_GetExecution" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentExecutionResource created on azure
            // for more information of creating ChaosExperimentExecutionResource, please refer to the document of ChaosExperimentExecutionResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            string executionId = "f24500ad-744e-4a26-864b-b76199eac333";
            ResourceIdentifier chaosExperimentExecutionResourceId = ChaosExperimentExecutionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName, executionId);
            ChaosExperimentExecutionResource chaosExperimentExecution = client.GetChaosExperimentExecutionResource(chaosExperimentExecutionResourceId);

            // invoke the operation
            ChaosExperimentExecutionResource result = await chaosExperimentExecution.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ChaosExperimentExecutionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task ExecutionDetails_GetExperimentExecutionDetails()
        {
            // Generated from example definition: 2025-01-01/Experiments_ExecutionDetails.json
            // this example is just showing the usage of "ExperimentExecutions_ExecutionDetails" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ChaosExperimentExecutionResource created on azure
            // for more information of creating ChaosExperimentExecutionResource, please refer to the document of ChaosExperimentExecutionResource
            string subscriptionId = "6b052e15-03d3-4f17-b2e1-be7f07588291";
            string resourceGroupName = "exampleRG";
            string experimentName = "exampleExperiment";
            string executionId = "f24500ad-744e-4a26-864b-b76199eac333";
            ResourceIdentifier chaosExperimentExecutionResourceId = ChaosExperimentExecutionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, experimentName, executionId);
            ChaosExperimentExecutionResource chaosExperimentExecution = client.GetChaosExperimentExecutionResource(chaosExperimentExecutionResourceId);

            // invoke the operation
            ExperimentExecutionDetails result = await chaosExperimentExecution.ExecutionDetailsAsync();

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
