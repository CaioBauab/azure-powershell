// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// BackupStatus request.
    /// </summary>
    public partial class BackupStatusRequest
    {
        /// <summary>
        /// Initializes a new instance of the BackupStatusRequest class.
        /// </summary>
        public BackupStatusRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupStatusRequest class.
        /// </summary>

        /// <param name="resourceType">Container Type - VM, SQLPaaS, DPM, AzureFileShare...
        /// Possible values include: &#39;Invalid&#39;, &#39;VM&#39;, &#39;FileFolder&#39;, &#39;AzureSqlDb&#39;,
        /// &#39;SQLDB&#39;, &#39;Exchange&#39;, &#39;Sharepoint&#39;, &#39;VMwareVM&#39;, &#39;SystemState&#39;, &#39;Client&#39;,
        /// &#39;GenericDataSource&#39;, &#39;SQLDataBase&#39;, &#39;AzureFileShare&#39;, &#39;SAPHanaDatabase&#39;,
        /// &#39;SAPAseDatabase&#39;, &#39;SAPHanaDBInstance&#39;</param>

        /// <param name="resourceId">Entire ARM resource id of the resource
        /// </param>

        /// <param name="poLogicalName">Protectable Item Logical Name
        /// </param>
        public BackupStatusRequest(string resourceType = default(string), string resourceId = default(string), string poLogicalName = default(string))

        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
            this.PoLogicalName = poLogicalName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets container Type - VM, SQLPaaS, DPM, AzureFileShare... Possible values include: &#39;Invalid&#39;, &#39;VM&#39;, &#39;FileFolder&#39;, &#39;AzureSqlDb&#39;, &#39;SQLDB&#39;, &#39;Exchange&#39;, &#39;Sharepoint&#39;, &#39;VMwareVM&#39;, &#39;SystemState&#39;, &#39;Client&#39;, &#39;GenericDataSource&#39;, &#39;SQLDataBase&#39;, &#39;AzureFileShare&#39;, &#39;SAPHanaDatabase&#39;, &#39;SAPAseDatabase&#39;, &#39;SAPHanaDBInstance&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceType")]
        public string ResourceType {get; set; }

        /// <summary>
        /// Gets or sets entire ARM resource id of the resource
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId {get; set; }

        /// <summary>
        /// Gets or sets protectable Item Logical Name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poLogicalName")]
        public string PoLogicalName {get; set; }
    }
}