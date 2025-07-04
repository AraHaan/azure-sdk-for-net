// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Resources.Samples
{
    public partial class Sample_ArmDeploymentScriptCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreate()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Create.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                CleanupPreference = ScriptCleanupOptions.Always,
                SupportingScriptUris = { new Uri("https://uri1.to.supporting.script"), new Uri("https://uri2.to.supporting.script") },
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Timeout = XmlConvert.ToTimeSpan("PT1H"),
                Identity = new ArmDeploymentScriptManagedIdentity
                {
                    IdentityType = ArmDeploymentScriptManagedIdentityType.UserAssigned,
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/uai"] = new UserAssignedIdentity()
},
                },
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreateNoUserManagedIdentity()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Create_No_UserManagedIdentity.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                CleanupPreference = ScriptCleanupOptions.Always,
                SupportingScriptUris = { new Uri("https://uri1.to.supporting.script"), new Uri("https://uri2.to.supporting.script") },
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Timeout = XmlConvert.ToTimeSpan("PT1H"),
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreateMinCreate()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Min_Create.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Identity = new ArmDeploymentScriptManagedIdentity
                {
                    IdentityType = ArmDeploymentScriptManagedIdentityType.UserAssigned,
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/uai"] = new UserAssignedIdentity()
},
                },
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreateUsingAciWithSubnets()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Create_Using_Custom_Aci_Name_With_SubnetIds.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                ContainerSettings = new ScriptContainerConfiguration
                {
                    ContainerGroupName = "contoso-aci",
                    SubnetIds = { new ScriptContainerGroupSubnet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.Network/virtualNetworks/scriptSubnet/subnets/subnetwork1")), new ScriptContainerGroupSubnet(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.Network/virtualNetworks/scriptSubnet/subnets/subnetwork2")) },
                },
                CleanupPreference = ScriptCleanupOptions.Always,
                SupportingScriptUris = { new Uri("https://uri1.to.supporting.script"), new Uri("https://uri2.to.supporting.script") },
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Timeout = XmlConvert.ToTimeSpan("PT1H"),
                Identity = new ArmDeploymentScriptManagedIdentity
                {
                    IdentityType = ArmDeploymentScriptManagedIdentityType.UserAssigned,
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/uai"] = new UserAssignedIdentity()
},
                },
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreateUsingCustomACIName()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Create_Using_Custom_Aci_Name.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                ContainerSettings = new ScriptContainerConfiguration
                {
                    ContainerGroupName = "contoso-aci",
                },
                CleanupPreference = ScriptCleanupOptions.Always,
                SupportingScriptUris = { new Uri("https://uri1.to.supporting.script"), new Uri("https://uri2.to.supporting.script") },
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Timeout = XmlConvert.ToTimeSpan("PT1H"),
                Identity = new ArmDeploymentScriptManagedIdentity
                {
                    IdentityType = ArmDeploymentScriptManagedIdentityType.UserAssigned,
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/uai"] = new UserAssignedIdentity()
},
                },
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_DeploymentScriptsCreateUsingExistingStorageAccount()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Create_Using_Existing_StorageAccount.json
            // this example is just showing the usage of "DeploymentScripts_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptData data = new AzurePowerShellScript(new AzureLocation("westus"), XmlConvert.ToTimeSpan("P7D"), "1.7.0")
            {
                StorageAccountSettings = new ScriptStorageConfiguration
                {
                    StorageAccountName = "contosostorage",
                    StorageAccountKey = "contosostoragekey",
                },
                CleanupPreference = ScriptCleanupOptions.Always,
                SupportingScriptUris = { new Uri("https://uri1.to.supporting.script"), new Uri("https://uri2.to.supporting.script") },
                ScriptContent = "Param([string]$Location,[string]$Name) $deploymentScriptOutputs['test'] = 'value' Get-AzResourceGroup -Location $Location -Name $Name",
                Arguments = "-Location 'westus' -Name \"*rg2\"",
                Timeout = XmlConvert.ToTimeSpan("PT1H"),
                Identity = new ArmDeploymentScriptManagedIdentity
                {
                    IdentityType = ArmDeploymentScriptManagedIdentityType.UserAssigned,
                    UserAssignedIdentities =
{
["/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/scriptRG/providers/Microsoft.ManagedIdentity/userAssignedIdentities/uai"] = new UserAssignedIdentity()
},
                },
            };
            ArmOperation<ArmDeploymentScriptResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, scriptName, data);
            ArmDeploymentScriptResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_DeploymentScriptsGet()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Get.json
            // this example is just showing the usage of "DeploymentScripts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            ArmDeploymentScriptResource result = await collection.GetAsync(scriptName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ArmDeploymentScriptData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_DeploymentScriptsList()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_ListByResourceGroup.json
            // this example is just showing the usage of "DeploymentScripts_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation and iterate over the result
            await foreach (ArmDeploymentScriptResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArmDeploymentScriptData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_DeploymentScriptsGet()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Get.json
            // this example is just showing the usage of "DeploymentScripts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            bool result = await collection.ExistsAsync(scriptName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_DeploymentScriptsGet()
        {
            // Generated from example definition: specification/resources/resource-manager/Microsoft.Resources/stable/2023-08-01/examples/DeploymentScripts_Get.json
            // this example is just showing the usage of "DeploymentScripts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "script-rg";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ArmDeploymentScriptResource
            ArmDeploymentScriptCollection collection = resourceGroupResource.GetArmDeploymentScripts();

            // invoke the operation
            string scriptName = "MyDeploymentScript";
            NullableResponse<ArmDeploymentScriptResource> response = await collection.GetIfExistsAsync(scriptName);
            ArmDeploymentScriptResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ArmDeploymentScriptData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
