// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StandbyPool.Models
{
    /// <summary> The updatable properties of the StandbyContainerGroupPoolResource. </summary>
    public partial class StandbyContainerGroupPoolUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="StandbyContainerGroupPoolUpdateProperties"/>. </summary>
        public StandbyContainerGroupPoolUpdateProperties()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="StandbyContainerGroupPoolUpdateProperties"/>. </summary>
        /// <param name="elasticityProfile"> Specifies elasticity profile of standby container group pools. </param>
        /// <param name="containerGroupProperties"> Specifies container group properties of standby container group pools. </param>
        /// <param name="zones"> Specifies zones of standby container group pools. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StandbyContainerGroupPoolUpdateProperties(StandbyContainerGroupPoolElasticityProfile elasticityProfile, StandbyContainerGroupProperties containerGroupProperties, IList<string> zones, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ElasticityProfile = elasticityProfile;
            ContainerGroupProperties = containerGroupProperties;
            Zones = zones;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies elasticity profile of standby container group pools. </summary>
        public StandbyContainerGroupPoolElasticityProfile ElasticityProfile { get; set; }
        /// <summary> Specifies container group properties of standby container group pools. </summary>
        public StandbyContainerGroupProperties ContainerGroupProperties { get; set; }
        /// <summary> Specifies zones of standby container group pools. </summary>
        public IList<string> Zones { get; }
    }
}
