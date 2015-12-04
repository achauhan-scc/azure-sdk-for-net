// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Previewed feature information.
    /// </summary>
    public partial class FeatureResult
    {
        /// <summary>
        /// Initializes a new instance of the FeatureResult class.
        /// </summary>
        public FeatureResult() { }

        /// <summary>
        /// Initializes a new instance of the FeatureResult class.
        /// </summary>
        public FeatureResult(string name = default(string), FeatureProperties properties = default(FeatureProperties), string id = default(string), string type = default(string))
        {
            Name = name;
            Properties = properties;
            Id = id;
            Type = type;
        }

        /// <summary>
        /// Gets or sets the name of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the properties of the previewed feature.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public FeatureProperties Properties { get; set; }

        /// <summary>
        /// Gets or sets the Id of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the feature.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
