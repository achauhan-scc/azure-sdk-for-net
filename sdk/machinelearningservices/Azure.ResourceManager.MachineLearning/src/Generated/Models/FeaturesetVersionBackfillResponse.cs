// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/FeaturesetVersionBackfillResponse.cs
    /// <summary> Response payload for creating a backfill request for a given feature set version. </summary>
    public partial class FeaturesetVersionBackfillResponse
========
    /// <summary> The AccountApiKeys. </summary>
    public partial class AccountApiKeys
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/AccountApiKeys.cs
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

<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/FeaturesetVersionBackfillResponse.cs
        /// <summary> Initializes a new instance of <see cref="FeaturesetVersionBackfillResponse"/>. </summary>
        internal FeaturesetVersionBackfillResponse()
========
        /// <summary> Initializes a new instance of <see cref="AccountApiKeys"/>. </summary>
        internal AccountApiKeys()
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/AccountApiKeys.cs
        {
            JobIds = new ChangeTrackingList<string>();
        }

<<<<<<<< HEAD:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/FeaturesetVersionBackfillResponse.cs
        /// <summary> Initializes a new instance of <see cref="FeaturesetVersionBackfillResponse"/>. </summary>
        /// <param name="jobIds"> List of jobs submitted as part of the backfill request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FeaturesetVersionBackfillResponse(IReadOnlyList<string> jobIds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobIds = jobIds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of jobs submitted as part of the backfill request. </summary>
        public IReadOnlyList<string> JobIds { get; }
========
        /// <summary> Initializes a new instance of <see cref="AccountApiKeys"/>. </summary>
        /// <param name="key1"></param>
        /// <param name="key2"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AccountApiKeys(string key1, string key2, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key1 = key1;
            Key2 = key2;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the key 1. </summary>
        public string Key1 { get; }
        /// <summary> Gets the key 2. </summary>
        public string Key2 { get; }
>>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7:sdk/machinelearningservices/Azure.ResourceManager.MachineLearning/src/Generated/Models/AccountApiKeys.cs
    }
}
