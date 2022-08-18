// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Web activity. </summary>
    public partial class WebActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of WebActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> Web activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public WebActivity(string name, WebActivityMethod method, BinaryData uri) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            Method = method;
            Uri = uri;
            Datasets = new ChangeTrackingList<DatasetReference>();
            LinkedServices = new ChangeTrackingList<FactoryLinkedServiceReference>();
            ActivityType = "WebActivity";
        }

        /// <summary> Initializes a new instance of WebActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="uri"> Web activity target endpoint and path. Type: string (or Expression with resultType string). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Authentication method used for calling the endpoint. </param>
        /// <param name="disableCertValidation"> When set to true, Certificate validation will be disabled. </param>
        /// <param name="datasets"> List of datasets passed to web endpoint. </param>
        /// <param name="linkedServices"> List of linked services passed to web endpoint. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        internal WebActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryLinkedServiceReference linkedServiceName, ActivityPolicy policy, WebActivityMethod method, BinaryData uri, BinaryData headers, BinaryData body, WebActivityAuthentication authentication, bool? disableCertValidation, IList<DatasetReference> datasets, IList<FactoryLinkedServiceReference> linkedServices, IntegrationRuntimeReference connectVia) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Method = method;
            Uri = uri;
            Headers = headers;
            Body = body;
            Authentication = authentication;
            DisableCertValidation = disableCertValidation;
            Datasets = datasets;
            LinkedServices = linkedServices;
            ConnectVia = connectVia;
            ActivityType = activityType ?? "WebActivity";
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public WebActivityMethod Method { get; set; }
        /// <summary>
        /// Web activity target endpoint and path. Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Uri { get; set; }
        /// <summary>
        /// Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Headers { get; set; }
        /// <summary>
        /// Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Body { get; set; }
        /// <summary> Authentication method used for calling the endpoint. </summary>
        public WebActivityAuthentication Authentication { get; set; }
        /// <summary> When set to true, Certificate validation will be disabled. </summary>
        public bool? DisableCertValidation { get; set; }
        /// <summary> List of datasets passed to web endpoint. </summary>
        public IList<DatasetReference> Datasets { get; }
        /// <summary> List of linked services passed to web endpoint. </summary>
        public IList<FactoryLinkedServiceReference> LinkedServices { get; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
    }
}
