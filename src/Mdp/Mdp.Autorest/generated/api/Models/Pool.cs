// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Extensions;

    /// <summary>
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    /// </summary>
    public partial class Pool :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPool,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.TrackedResource();

        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAgentProfile AgentProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).AgentProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).AgentProfile = value ?? null /* model class */; }

        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public string DevCenterProjectResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).DevCenterProjectResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).DevCenterProjectResourceId = value ?? null; }

        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IFabricProfile FabricProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).FabricProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).FabricProfile = value ?? null /* model class */; }

        /// <summary>
        /// Fully qualified resource ID for the resource. E.g. "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentity _identity;

        /// <summary>The managed service identities assigned to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceInternal)__trackedResource).Location = value ; }

        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public int? MaximumConcurrency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).MaximumConcurrency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).MaximumConcurrency = value ?? default(int); }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolProperties Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.PoolProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IOrganizationProfile OrganizationProfile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).OrganizationProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).OrganizationProfile = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolProperties _property;

        /// <summary>The resource-specific properties for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.PoolProperties()); set => this._property = value; }

        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolPropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Origin(Microsoft.Azure.PowerShell.Cmdlets.Mdp.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Pool" /> instance.</summary>
        public Pool()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    public partial interface IPool :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResource
    {
        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines how the machine will be handled once it executed a job.",
        SerializedName = @"agentProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAgentProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the DevCenter Project the pool belongs to.",
        SerializedName = @"devCenterProjectResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the type of fabric the agent will run on.",
        SerializedName = @"fabricProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IFabricProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IFabricProfile FabricProfile { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines how many resources can there be created at any given time.",
        SerializedName = @"maximumConcurrency",
        PossibleTypes = new [] { typeof(int) })]
        int? MaximumConcurrency { get; set; }
        /// <summary>Defines the organization in which the pool will be used.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the organization in which the pool will be used.",
        SerializedName = @"organizationProfile",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IOrganizationProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IOrganizationProfile OrganizationProfile { get; set; }
        /// <summary>The status of the current operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Mdp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status of the current operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
    /// Concrete tracked resource types can be created by aliasing this type using a specific property type.
    internal partial interface IPoolInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.ITrackedResourceInternal
    {
        /// <summary>Defines how the machine will be handled once it executed a job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IAgentProfile AgentProfile { get; set; }
        /// <summary>The resource id of the DevCenter Project the pool belongs to.</summary>
        string DevCenterProjectResourceId { get; set; }
        /// <summary>Defines the type of fabric the agent will run on.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IFabricProfile FabricProfile { get; set; }
        /// <summary>The managed service identities assigned to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Defines how many resources can there be created at any given time.</summary>
        int? MaximumConcurrency { get; set; }
        /// <summary>Defines the organization in which the pool will be used.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IOrganizationProfile OrganizationProfile { get; set; }
        /// <summary>The resource-specific properties for this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Mdp.Models.IPoolProperties Property { get; set; }
        /// <summary>The status of the current operation.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Mdp.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted")]
        string ProvisioningState { get; set; }

    }
}