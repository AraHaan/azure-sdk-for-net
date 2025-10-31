// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using ClientModel.Tests.Mocks;
using NUnit.Framework;

namespace System.ClientModel.Tests.Message;

public class PipelineRequestTests
{
    [Test]
    public void ClientRequestId_LazyInitializes()
    {
        // Arrange
        ClientPipeline pipeline = ClientPipeline.Create();
        PipelineMessage message = pipeline.CreateMessage();

        // Act - Access ClientRequestId without setting it
        string clientRequestId = message.Request.ClientRequestId;

        // Assert - Should be auto-generated and not null
        Assert.IsNotNull(clientRequestId);
        Assert.IsNotEmpty(clientRequestId);
    }

    [Test]
    public void ClientRequestId_ReturnsConsistentValue()
    {
        // Arrange
        ClientPipeline pipeline = ClientPipeline.Create();
        PipelineMessage message = pipeline.CreateMessage();

        // Act - Access ClientRequestId multiple times
        string firstAccess = message.Request.ClientRequestId;
        string secondAccess = message.Request.ClientRequestId;

        // Assert - Should return the same value
        Assert.AreEqual(firstAccess, secondAccess);
    }

    [Test]
    public void ClientRequestId_IsReadOnly()
    {
        // Arrange
        ClientPipeline pipeline = ClientPipeline.Create();
        PipelineMessage message = pipeline.CreateMessage();

        // Act - Access ClientRequestId
        string clientRequestId = message.Request.ClientRequestId;

        // Assert - Should be auto-generated and consistent
        Assert.IsNotNull(clientRequestId);
        Assert.IsNotEmpty(clientRequestId);
        Assert.AreEqual(clientRequestId, message.Request.ClientRequestId);
    }

    [Test]
    public void ClientRequestId_UsesActivityIdWhenAvailable()
    {
        // Arrange
        ClientPipeline pipeline = ClientPipeline.Create();
        PipelineMessage message = pipeline.CreateMessage();

        using Activity activity = new Activity("test-activity");
        activity.Start();

        // Act - Access ClientRequestId while Activity is active
        string clientRequestId = message.Request.ClientRequestId;

        // Assert - Should use Activity.Current.Id
        Assert.AreEqual(Activity.Current?.Id, clientRequestId);
    }

    [Test]
    public void ClientRequestId_IsAccessibleFromCustomPolicy()
    {
        // Arrange
        string? capturedRequestId = null;

        ClientPipelineOptions options = new();
        options.Transport = new ObservableTransport("Transport");
        options.AddPolicy(new TestClientRequestIdPolicy((id) => capturedRequestId = id), PipelinePosition.PerCall);

        ClientPipeline pipeline = ClientPipeline.Create(options);
        PipelineMessage message = pipeline.CreateMessage();

        // Act - Send message through pipeline
        pipeline.Send(message);

        // Assert - Custom policy should be able to access ClientRequestId
        Assert.IsNotNull(capturedRequestId);
        Assert.IsNotEmpty(capturedRequestId);
        Assert.AreEqual(message.Request.ClientRequestId, capturedRequestId);
    }

    #region Helper Classes

    private class TestClientRequestIdPolicy : PipelinePolicy
    {
        private readonly Action<string> _onClientRequestId;

        public TestClientRequestIdPolicy(Action<string> onClientRequestId)
        {
            _onClientRequestId = onClientRequestId;
        }

        public override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
        {
            _onClientRequestId(message.Request.ClientRequestId);
            ProcessNext(message, pipeline, currentIndex);
        }

        public override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
        {
            _onClientRequestId(message.Request.ClientRequestId);
            await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);
        }
    }

    #endregion
}
