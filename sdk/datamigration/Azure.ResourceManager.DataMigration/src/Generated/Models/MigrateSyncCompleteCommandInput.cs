// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for command that completes sync migration for a database. </summary>
    public partial class MigrateSyncCompleteCommandInput
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

        /// <summary> Initializes a new instance of <see cref="MigrateSyncCompleteCommandInput"/>. </summary>
        /// <param name="databaseName"> Name of database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public MigrateSyncCompleteCommandInput(string databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            DatabaseName = databaseName;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSyncCompleteCommandInput"/>. </summary>
        /// <param name="databaseName"> Name of database. </param>
        /// <param name="completedOn"> Time stamp to complete. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MigrateSyncCompleteCommandInput(string databaseName, DateTimeOffset? completedOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DatabaseName = databaseName;
            CompletedOn = completedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSyncCompleteCommandInput"/> for deserialization. </summary>
        internal MigrateSyncCompleteCommandInput()
        {
        }

        /// <summary> Name of database. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Time stamp to complete. </summary>
        public DateTimeOffset? CompletedOn { get; set; }
    }
}
