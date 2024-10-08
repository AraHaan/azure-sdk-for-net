// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The BlobReferenceForConsumptionDto. </summary>
    public partial class BlobReferenceForConsumptionDto
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BlobReferenceForConsumptionDto"/>. </summary>
        internal BlobReferenceForConsumptionDto()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BlobReferenceForConsumptionDto"/>. </summary>
        /// <param name="blobUri">
        /// Blob URI path for client to upload data.
        /// Example: https://blob.windows.core.net/Container/Path
        /// </param>
        /// <param name="storageAccountArmId"> Arm ID of the storage account to use. </param>
        /// <param name="credential">
        /// Credential info to access storage account
        /// Please note <see cref="PendingUploadCredentialDto"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SasCredentialDto"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobReferenceForConsumptionDto(Uri blobUri, ResourceIdentifier storageAccountArmId, PendingUploadCredentialDto credential, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlobUri = blobUri;
            StorageAccountArmId = storageAccountArmId;
            Credential = credential;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Blob URI path for client to upload data.
        /// Example: https://blob.windows.core.net/Container/Path
        /// </summary>
        [WirePath("blobUri")]
        public Uri BlobUri { get; }
        /// <summary> Arm ID of the storage account to use. </summary>
        [WirePath("storageAccountArmId")]
        public ResourceIdentifier StorageAccountArmId { get; }
        /// <summary>
        /// Credential info to access storage account
        /// Please note <see cref="PendingUploadCredentialDto"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SasCredentialDto"/>.
        /// </summary>
        [WirePath("credential")]
        public PendingUploadCredentialDto Credential { get; }
    }
}
