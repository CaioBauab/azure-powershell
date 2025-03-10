// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Update Logger operation.
    /// </summary>
    public partial class LoggerUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the LoggerUpdateParameters class.
        /// </summary>
        public LoggerUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LoggerUpdateParameters class.
        /// </summary>

        /// <param name="loggerType">Logger type.
        /// Possible values include: &#39;azureEventHub&#39;, &#39;applicationInsights&#39;,
        /// &#39;azureMonitor&#39;</param>

        /// <param name="description">Logger description.
        /// </param>

        /// <param name="credentials">Logger credentials.
        /// </param>

        /// <param name="isBuffered">Whether records are buffered in the logger before publishing. Default is
        /// assumed to be true.
        /// </param>
        public LoggerUpdateParameters(string loggerType = default(string), string description = default(string), System.Collections.Generic.IDictionary<string, string> credentials = default(System.Collections.Generic.IDictionary<string, string>), bool? isBuffered = default(bool?))

        {
            this.LoggerType = loggerType;
            this.Description = description;
            this.Credentials = credentials;
            this.IsBuffered = isBuffered;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets logger type. Possible values include: &#39;azureEventHub&#39;, &#39;applicationInsights&#39;, &#39;azureMonitor&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "loggerType")]
        public string LoggerType {get; set; }

        /// <summary>
        /// Gets or sets logger description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets logger credentials.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "credentials")]
        public System.Collections.Generic.IDictionary<string, string> Credentials {get; set; }

        /// <summary>
        /// Gets or sets whether records are buffered in the logger before publishing.
        /// Default is assumed to be true.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isBuffered")]
        public bool? IsBuffered {get; set; }
    }
}