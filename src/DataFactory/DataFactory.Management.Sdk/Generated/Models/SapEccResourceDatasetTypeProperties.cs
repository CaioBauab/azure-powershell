// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Sap ECC OData resource dataset properties.
    /// </summary>
    public partial class SapEccResourceDatasetTypeProperties
    {
        /// <summary>
        /// Initializes a new instance of the SapEccResourceDatasetTypeProperties class.
        /// </summary>
        public SapEccResourceDatasetTypeProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapEccResourceDatasetTypeProperties class.
        /// </summary>

        /// <param name="path">The path of the SAP ECC OData entity. Type: string (or Expression with
        /// resultType string).
        /// </param>
        public SapEccResourceDatasetTypeProperties(object path)

        {
            this.Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the path of the SAP ECC OData entity. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "path")]
        public object Path {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Path == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Path");
            }

        }
    }
}