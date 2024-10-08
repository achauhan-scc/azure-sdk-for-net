// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningAssetBase. </summary>
    public partial class MachineLearningAssetBase : MachineLearningResourceBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAssetBase"/>. </summary>
        public MachineLearningAssetBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAssetBase"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
<<<<<<< HEAD
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        internal MachineLearningAssetBase(string description, IDictionary<string, string> tags, IDictionary<string, string> properties, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isArchived, bool? isAnonymous) : base(description, tags, properties, serializedAdditionalRawData)
        {
=======
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        internal MachineLearningAssetBase(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isAnonymous, bool? isArchived) : base(description, properties, tags, serializedAdditionalRawData)
        {
            IsAnonymous = isAnonymous;
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
            IsArchived = isArchived;
            IsAnonymous = isAnonymous;
        }

<<<<<<< HEAD
=======
        /// <summary> If the name version are system generated (anonymous registration). </summary>
        public bool? IsAnonymous { get; set; }
>>>>>>> 3f8cf30a3ebe61cfdd08f1bbe8fa5494eda0e9f7
        /// <summary> Is the asset archived?. </summary>
        public bool? IsArchived { get; set; }
        /// <summary> If the name version are system generated (anonymous registration). </summary>
        public bool? IsAnonymous { get; set; }
    }
}
