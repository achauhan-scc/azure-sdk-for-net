// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningUriFolderJobOutput. </summary>
    public partial class MachineLearningUriFolderJobOutput : MachineLearningJobOutput
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFolderJobOutput"/>. </summary>
        public MachineLearningUriFolderJobOutput()
        {
            JobOutputType = JobOutputType.UriFolder;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFolderJobOutput"/>. </summary>
        /// <param name="jobOutputType"> [Required] Specifies the type of job. </param>
        /// <param name="description"> Description for the output. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
<<<<<<< HEAD
        /// <param name="uri"> Output Asset URI. </param>
        /// <param name="mode"> Output Asset Delivery Mode. </param>
        internal MachineLearningUriFolderJobOutput(JobOutputType jobOutputType, string description, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri uri, MachineLearningOutputDeliveryMode? mode) : base(jobOutputType, description, serializedAdditionalRawData)
        {
=======
        /// <param name="mode"> Output Asset Delivery Mode. </param>
        /// <param name="uri"> Output Asset URI. </param>
        internal MachineLearningUriFolderJobOutput(string description, JobOutputType jobOutputType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningOutputDeliveryMode? mode, Uri uri) : base(description, jobOutputType, serializedAdditionalRawData)
        {
            Mode = mode;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            Uri = uri;
            Mode = mode;
            JobOutputType = jobOutputType;
        }

<<<<<<< HEAD
=======
        /// <summary> Output Asset Delivery Mode. </summary>
        public MachineLearningOutputDeliveryMode? Mode { get; set; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <summary> Output Asset URI. </summary>
        public Uri Uri { get; set; }
        /// <summary> Output Asset Delivery Mode. </summary>
        public MachineLearningOutputDeliveryMode? Mode { get; set; }
    }
}
