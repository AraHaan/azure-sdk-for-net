// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing the RegionInfoResource data model.
    /// Information regarding regionInfo Item.
    /// Serialized Name: RegionInfoResource
    /// </summary>
    public partial class RegionInfoResourceData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="RegionInfoResourceData"/>. </summary>
        public RegionInfoResourceData()
        {
            AvailabilityZoneMappings = new ChangeTrackingList<AvailabilityZoneMapping>();
        }

        /// <summary> Initializes a new instance of <see cref="RegionInfoResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageToNetworkProximity">
        /// Provides storage to network proximity information in the region.
        /// Serialized Name: RegionInfoResource.properties.storageToNetworkProximity
        /// </param>
        /// <param name="availabilityZoneMappings">
        /// Provides logical availability zone mappings for the subscription for a region.
        /// Serialized Name: RegionInfoResource.properties.availabilityZoneMappings
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RegionInfoResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RegionStorageToNetworkProximity? storageToNetworkProximity, IList<AvailabilityZoneMapping> availabilityZoneMappings, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StorageToNetworkProximity = storageToNetworkProximity;
            AvailabilityZoneMappings = availabilityZoneMappings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Provides storage to network proximity information in the region.
        /// Serialized Name: RegionInfoResource.properties.storageToNetworkProximity
        /// </summary>
        public RegionStorageToNetworkProximity? StorageToNetworkProximity { get; set; }
        /// <summary>
        /// Provides logical availability zone mappings for the subscription for a region.
        /// Serialized Name: RegionInfoResource.properties.availabilityZoneMappings
        /// </summary>
        public IList<AvailabilityZoneMapping> AvailabilityZoneMappings { get; }
    }
}
