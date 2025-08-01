// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputMigrationLevel. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputMigrationLevel : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputMigrationLevel"/>. </summary>
        internal MigrateSqlServerSqlDBTaskOutputMigrationLevel()
        {
            ExceptionsAndWarnings = new ChangeTrackingList<DataMigrationReportableException>();
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlDBTaskOutputMigrationLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="durationInSeconds"> Duration of task execution in seconds. </param>
        /// <param name="status"> Current status of migration. </param>
        /// <param name="statusMessage"> Migration status message. </param>
        /// <param name="message"> Migration progress message. </param>
        /// <param name="databases"> Selected databases as a map from database name to database id. </param>
        /// <param name="databaseSummary"> Summary of database results in the migration. </param>
        /// <param name="migrationValidationResult"> Migration Validation Results. </param>
        /// <param name="migrationReportResult"> Migration Report Result, provides unique url for downloading your migration report. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServerBrandVersion"> Source server brand version. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        internal MigrateSqlServerSqlDBTaskOutputMigrationLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? startedOn, DateTimeOffset? endedOn, long? durationInSeconds, DataMigrationStatus? status, string statusMessage, string message, string databases, string databaseSummary, MigrationValidationResult migrationValidationResult, MigrationReportResult migrationReportResult, string sourceServerVersion, string sourceServerBrandVersion, string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<DataMigrationReportableException> exceptionsAndWarnings) : base(id, resultType, serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            DurationInSeconds = durationInSeconds;
            Status = status;
            StatusMessage = statusMessage;
            Message = message;
            Databases = databases;
            DatabaseSummary = databaseSummary;
            MigrationValidationResult = migrationValidationResult;
            MigrationReportResult = migrationReportResult;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Duration of task execution in seconds. </summary>
        public long? DurationInSeconds { get; }
        /// <summary> Current status of migration. </summary>
        public DataMigrationStatus? Status { get; }
        /// <summary> Migration status message. </summary>
        public string StatusMessage { get; }
        /// <summary> Migration progress message. </summary>
        public string Message { get; }
        /// <summary> Selected databases as a map from database name to database id. </summary>
        public string Databases { get; }
        /// <summary> Summary of database results in the migration. </summary>
        public string DatabaseSummary { get; }
        /// <summary> Migration Validation Results. </summary>
        public MigrationValidationResult MigrationValidationResult { get; }
        /// <summary> Migration Report Result, provides unique url for downloading your migration report. </summary>
        public MigrationReportResult MigrationReportResult { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<DataMigrationReportableException> ExceptionsAndWarnings { get; }
    }
}
