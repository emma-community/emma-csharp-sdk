/*
 * Public EMMA API
 *
 * ### About Infrastructure API  **Base URL:** **<u>https://api.emma.ms/external</u>**   This **Infrastructure API** is for managing the emma cloud infrastructure within a project. The API enables you to view, create, edit, and delete _Virtual machines, Spot instances, Applications, Kubernetes clusters, SSH keys, Security groups, and Backup policies_. For creating the resources you can use the endpoints with the dictionaries: _Data centers, Locations, Providers, Operating systems, Virtual machines configurations, Spot instances configurations, Kubernetes clusters configurations._   ### Authentication   #### 1. Create service application   To access the API, enter your project, navigate to **Settings** > **Service Apps**, and create a service application. Select the access level **Read**, **Operate**, or **Manage**.   - **Read** - only GET methods are allowed in the API.   - **Operate** - some operations are allowed with the resources (e.g. _Start, Reboot,_ and _Shutdown_ of the Virtual machines).   - **Manage** - full creating, updating, and deleting of the resources is allowed.    #### 2. Get access token   - Copy the **Client ID** and **Client Secret** in the service application.  - Send an API request to the endpoint **_/issue-token** as specified in the **Authentication** section of the API documentation. You will receive access and refresh tokens in the response.   _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token \\  -H \"Content-Type: application/json\" \\  -d '{\"clientId\": \"YOUR-CLIENT-ID\", \"clientSecret\": \"YOUR-CLIENT-SECRET\"}'  ```  _For Windows:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token ^  -H \"Content-Type: application/json\" ^  -d \"{\\\"clientId\\\": \\\"YOUR-CLIENT-ID\\\", \\\"clientSecret\\\": \\\"YOUR-CLIENT-SECRET\\\"}\"  ```   #### 3. Use access token in requests  The Bearer access token is a text string, included in the request header, for example:   _For Linux / Mac:_  ```  curl -X GET https://api.emma.ms/external/v1/locations -H \"Authorization: Bearer YOUR-ACCESS-TOKEN-HERE\"  ```   Use this token for the API requests.    #### 4. Refresh token  The access token will expire in 10 minutes. A new access token may be created using the refresh token (without Client ID and Client Secret).   To get a new access token send a request to the **_/refresh-token** endpoint:    _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/refresh-token \\  -H \"Content-Type: application/json\" \\  -d '{\"refreshToken\": \"YOUR-REFRESH-TOKEN\"}'  ```       ### Possible response status codes   We use standard HTTP response codes to show the success or failure of requests.   `2xx` - successful responses.   `4xx` - client error responses (the response contains an explanation of the error).   `5xx` - server error responses.   The API uses the following status codes:   | Status Code | Description                  | Notes                                                                  |  |- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|  | 200         | OK                           | The request was successful.                                             |  | 201         | Created                      | The object was successfully created. This code is only used with objects that are created immediately.  | 204         | No content                   | A successful request, but there is no additional information to send back in the response body (in a case when the object was deleted).    | 400         | Bad Request                  | The request could not be understood by the server. Incoming parameters might not be valid. |  | 401         | Unauthorized            | The client is unauthenticated. The client must authenticate itself to get the requested response. |  | 403         | Forbidden                   | The client does not have access rights to the content.  | 404         | Not Found                    | The requested resource is not found.                                    |  | 409         | Conflict | This response is sent when a request conflicts with the current state of the object (e.g. deleting the security group with the compute instances in it).|  | 422         | Unprocessable Content   | The request was well-formed but was unable to be followed due to incorrect field values (e.g. creation of a virtual machine in the non-existent data center).  |  | 500         | Internal server Error                 | The server could not return the representation due to an internal server error. | 
 *
 * The version of the OpenAPI document: 1.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// SecurityGroup
    /// </summary>
    [DataContract(Name = "SecurityGroup")]
    public partial class SecurityGroup : IValidatableObject
    {
        /// <summary>
        /// Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized.
        /// </summary>
        /// <value>Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SynchronizationStatusEnum
        {
            /// <summary>
            /// Enum SYNCHRONIZED for value: SYNCHRONIZED
            /// </summary>
            [EnumMember(Value = "SYNCHRONIZED")]
            SYNCHRONIZED = 1,

            /// <summary>
            /// Enum DESYNCHRONIZED for value: DESYNCHRONIZED
            /// </summary>
            [EnumMember(Value = "DESYNCHRONIZED")]
            DESYNCHRONIZED = 2,

            /// <summary>
            /// Enum SYNCHRONIZING for value: SYNCHRONIZING
            /// </summary>
            [EnumMember(Value = "SYNCHRONIZING")]
            SYNCHRONIZING = 3
        }


        /// <summary>
        /// Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized.
        /// </summary>
        /// <value>Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized.</value>
        [DataMember(Name = "synchronizationStatus", EmitDefaultValue = false)]
        public SynchronizationStatusEnum? SynchronizationStatus { get; set; }
        /// <summary>
        /// Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status.
        /// </summary>
        /// <value>Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecomposingStatusEnum
        {
            /// <summary>
            /// Enum RECOMPOSED for value: RECOMPOSED
            /// </summary>
            [EnumMember(Value = "RECOMPOSED")]
            RECOMPOSED = 1,

            /// <summary>
            /// Enum RECOMPOSING for value: RECOMPOSING
            /// </summary>
            [EnumMember(Value = "RECOMPOSING")]
            RECOMPOSING = 2
        }


        /// <summary>
        /// Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status.
        /// </summary>
        /// <value>Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status.</value>
        [DataMember(Name = "recomposingStatus", EmitDefaultValue = false)]
        public RecomposingStatusEnum? RecomposingStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityGroup" /> class.
        /// </summary>
        /// <param name="id">Security group id.</param>
        /// <param name="name">Security group name.</param>
        /// <param name="createdById">ID of the user who created the security group.</param>
        /// <param name="createdByName">Name of the user who created the security group.</param>
        /// <param name="modifiedById">ID of the user who last edited the security group.</param>
        /// <param name="modifiedByName">Name of the user who last edited the security group.</param>
        /// <param name="createdAt">Date and time of the security group&#39;s creation.</param>
        /// <param name="modifiedAt">Date and time of the security group&#39;s last update.</param>
        /// <param name="synchronizationStatus">Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized..</param>
        /// <param name="recomposingStatus">Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status..</param>
        /// <param name="lastModificationErrorDescription">Text of the error when the Security group was last edited.</param>
        /// <param name="rules">List of the inbound and outbound rules in the Security group.</param>
        public SecurityGroup(int id = default(int), string name = default(string), int createdById = default(int), string createdByName = default(string), int modifiedById = default(int), string modifiedByName = default(string), string createdAt = default(string), string modifiedAt = default(string), SynchronizationStatusEnum? synchronizationStatus = default(SynchronizationStatusEnum?), RecomposingStatusEnum? recomposingStatus = default(RecomposingStatusEnum?), string lastModificationErrorDescription = default(string), List<SecurityGroupRule> rules = default(List<SecurityGroupRule>))
        {
            this.Id = id;
            this.Name = name;
            this.CreatedById = createdById;
            this.CreatedByName = createdByName;
            this.ModifiedById = modifiedById;
            this.ModifiedByName = modifiedByName;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.SynchronizationStatus = synchronizationStatus;
            this.RecomposingStatus = recomposingStatus;
            this.LastModificationErrorDescription = lastModificationErrorDescription;
            this.Rules = rules;
        }

        /// <summary>
        /// Security group id
        /// </summary>
        /// <value>Security group id</value>
        /// <example>5</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Security group name
        /// </summary>
        /// <value>Security group name</value>
        /// <example>default</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// ID of the user who created the security group
        /// </summary>
        /// <value>ID of the user who created the security group</value>
        /// <example>123</example>
        [DataMember(Name = "createdById", EmitDefaultValue = false)]
        public int CreatedById { get; set; }

        /// <summary>
        /// Name of the user who created the security group
        /// </summary>
        /// <value>Name of the user who created the security group</value>
        /// <example>Jack Rur</example>
        [DataMember(Name = "createdByName", EmitDefaultValue = false)]
        public string CreatedByName { get; set; }

        /// <summary>
        /// ID of the user who last edited the security group
        /// </summary>
        /// <value>ID of the user who last edited the security group</value>
        /// <example>123</example>
        [DataMember(Name = "modifiedById", EmitDefaultValue = false)]
        public int ModifiedById { get; set; }

        /// <summary>
        /// Name of the user who last edited the security group
        /// </summary>
        /// <value>Name of the user who last edited the security group</value>
        /// <example>Jack Rur</example>
        [DataMember(Name = "modifiedByName", EmitDefaultValue = false)]
        public string ModifiedByName { get; set; }

        /// <summary>
        /// Date and time of the security group&#39;s creation
        /// </summary>
        /// <value>Date and time of the security group&#39;s creation</value>
        /// <example>2023-08-31T09:26:19.347+00:00</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Date and time of the security group&#39;s last update
        /// </summary>
        /// <value>Date and time of the security group&#39;s last update</value>
        /// <example>2023-08-31T09:26:19.347+00:00</example>
        [DataMember(Name = "modifiedAt", EmitDefaultValue = false)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Text of the error when the Security group was last edited
        /// </summary>
        /// <value>Text of the error when the Security group was last edited</value>
        /// <example>Unable to update security group</example>
        [DataMember(Name = "lastModificationErrorDescription", EmitDefaultValue = false)]
        public string LastModificationErrorDescription { get; set; }

        /// <summary>
        /// List of the inbound and outbound rules in the Security group
        /// </summary>
        /// <value>List of the inbound and outbound rules in the Security group</value>
        [DataMember(Name = "rules", EmitDefaultValue = false)]
        public List<SecurityGroupRule> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedById: ").Append(CreatedById).Append("\n");
            sb.Append("  CreatedByName: ").Append(CreatedByName).Append("\n");
            sb.Append("  ModifiedById: ").Append(ModifiedById).Append("\n");
            sb.Append("  ModifiedByName: ").Append(ModifiedByName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  SynchronizationStatus: ").Append(SynchronizationStatus).Append("\n");
            sb.Append("  RecomposingStatus: ").Append(RecomposingStatus).Append("\n");
            sb.Append("  LastModificationErrorDescription: ").Append(LastModificationErrorDescription).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
