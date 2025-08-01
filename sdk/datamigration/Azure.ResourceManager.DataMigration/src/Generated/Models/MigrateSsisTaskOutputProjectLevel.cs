// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSsisTaskOutputProjectLevel. </summary>
    public partial class MigrateSsisTaskOutputProjectLevel : MigrateSsisTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSsisTaskOutputProjectLevel"/>. </summary>
        internal MigrateSsisTaskOutputProjectLevel()
        {
            ExceptionsAndWarnings = new ChangeTrackingList<DataMigrationReportableException>();
            ResultType = "SsisProjectLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSsisTaskOutputProjectLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="folderName"> Name of the folder. </param>
        /// <param name="projectName"> Name of the project. </param>
        /// <param name="state"> Current state of migration. </param>
        /// <param name="stage"> Stage of SSIS migration. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="message"> Migration progress message. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        internal MigrateSsisTaskOutputProjectLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string folderName, string projectName, DataMigrationState? state, SsisMigrationStage? stage, DateTimeOffset? startedOn, DateTimeOffset? endedOn, string message, IReadOnlyList<DataMigrationReportableException> exceptionsAndWarnings) : base(id, resultType, serializedAdditionalRawData)
        {
            FolderName = folderName;
            ProjectName = projectName;
            State = state;
            Stage = stage;
            StartedOn = startedOn;
            EndedOn = endedOn;
            Message = message;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            ResultType = resultType ?? "SsisProjectLevelOutput";
        }

        /// <summary> Name of the folder. </summary>
        public string FolderName { get; }
        /// <summary> Name of the project. </summary>
        public string ProjectName { get; }
        /// <summary> Current state of migration. </summary>
        public DataMigrationState? State { get; }
        /// <summary> Stage of SSIS migration. </summary>
        public SsisMigrationStage? Stage { get; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Migration progress message. </summary>
        public string Message { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<DataMigrationReportableException> ExceptionsAndWarnings { get; }
    }
}
