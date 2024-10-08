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
    /// VmConfiguration
    /// </summary>
    [DataContract(Name = "VmConfiguration")]
    public partial class VmConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmConfiguration" /> class.
        /// </summary>
        /// <param name="id">Configuration ID.</param>
        /// <param name="providerId">ID of the cloud provider.</param>
        /// <param name="providerName">Name of the cloud provider.</param>
        /// <param name="locationId">Location ID.</param>
        /// <param name="locationName">Location name (city or state).</param>
        /// <param name="dataCenterId">ID of the data center.</param>
        /// <param name="dataCenterName">Name of the data center.</param>
        /// <param name="osId">ID of the operating system.</param>
        /// <param name="osType">Type of the operating system.</param>
        /// <param name="osVersion">Version of the operating system.</param>
        /// <param name="cloudNetworkTypes">List of the cloud network types.</param>
        /// <param name="vCpuType">Type of virtual Central Processing Units (vCPUs).</param>
        /// <param name="vCpu">Number of virtual Central Processing Units (vCPUs).</param>
        /// <param name="ramGb">Capacity of the RAM in gigabytes.</param>
        /// <param name="volumeGb">Capacity of the volume in gigabytes.</param>
        /// <param name="volumeType">Volume type.</param>
        /// <param name="cost">cost.</param>
        public VmConfiguration(int id = default(int), int providerId = default(int), string providerName = default(string), int locationId = default(int), string locationName = default(string), string dataCenterId = default(string), string dataCenterName = default(string), int osId = default(int), string osType = default(string), string osVersion = default(string), List<string> cloudNetworkTypes = default(List<string>), string vCpuType = default(string), int vCpu = default(int), int ramGb = default(int), int volumeGb = default(int), string volumeType = default(string), VmConfigurationCost cost = default(VmConfigurationCost))
        {
            this.Id = id;
            this.ProviderId = providerId;
            this.ProviderName = providerName;
            this.LocationId = locationId;
            this.LocationName = locationName;
            this.DataCenterId = dataCenterId;
            this.DataCenterName = dataCenterName;
            this.OsId = osId;
            this.OsType = osType;
            this.OsVersion = osVersion;
            this.CloudNetworkTypes = cloudNetworkTypes;
            this.VCpuType = vCpuType;
            this.VCpu = vCpu;
            this.RamGb = ramGb;
            this.VolumeGb = volumeGb;
            this.VolumeType = volumeType;
            this.Cost = cost;
        }

        /// <summary>
        /// Configuration ID
        /// </summary>
        /// <value>Configuration ID</value>
        /// <example>2456</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// ID of the cloud provider
        /// </summary>
        /// <value>ID of the cloud provider</value>
        /// <example>5</example>
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Name of the cloud provider
        /// </summary>
        /// <value>Name of the cloud provider</value>
        /// <example>GCP</example>
        [DataMember(Name = "providerName", EmitDefaultValue = false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Location ID
        /// </summary>
        /// <value>Location ID</value>
        /// <example>6</example>
        [DataMember(Name = "locationId", EmitDefaultValue = false)]
        public int LocationId { get; set; }

        /// <summary>
        /// Location name (city or state)
        /// </summary>
        /// <value>Location name (city or state)</value>
        /// <example>London</example>
        [DataMember(Name = "locationName", EmitDefaultValue = false)]
        public string LocationName { get; set; }

        /// <summary>
        /// ID of the data center
        /// </summary>
        /// <value>ID of the data center</value>
        /// <example>aws-us-west-1</example>
        [DataMember(Name = "dataCenterId", EmitDefaultValue = false)]
        public string DataCenterId { get; set; }

        /// <summary>
        /// Name of the data center
        /// </summary>
        /// <value>Name of the data center</value>
        /// <example>europe-west2</example>
        [DataMember(Name = "dataCenterName", EmitDefaultValue = false)]
        public string DataCenterName { get; set; }

        /// <summary>
        /// ID of the operating system
        /// </summary>
        /// <value>ID of the operating system</value>
        /// <example>35</example>
        [DataMember(Name = "osId", EmitDefaultValue = false)]
        public int OsId { get; set; }

        /// <summary>
        /// Type of the operating system
        /// </summary>
        /// <value>Type of the operating system</value>
        /// <example>Ubuntu</example>
        [DataMember(Name = "osType", EmitDefaultValue = false)]
        public string OsType { get; set; }

        /// <summary>
        /// Version of the operating system
        /// </summary>
        /// <value>Version of the operating system</value>
        /// <example>18.04</example>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// List of the cloud network types
        /// </summary>
        /// <value>List of the cloud network types</value>
        /// <example>[&quot;default&quot;,&quot;multi-cloud&quot;,&quot;isolated&quot;]</example>
        [DataMember(Name = "cloudNetworkTypes", EmitDefaultValue = false)]
        public List<string> CloudNetworkTypes { get; set; }

        /// <summary>
        /// Type of virtual Central Processing Units (vCPUs)
        /// </summary>
        /// <value>Type of virtual Central Processing Units (vCPUs)</value>
        /// <example>Standard</example>
        [DataMember(Name = "vCpuType", EmitDefaultValue = false)]
        public string VCpuType { get; set; }

        /// <summary>
        /// Number of virtual Central Processing Units (vCPUs)
        /// </summary>
        /// <value>Number of virtual Central Processing Units (vCPUs)</value>
        /// <example>4</example>
        [DataMember(Name = "vCpu", EmitDefaultValue = false)]
        public int VCpu { get; set; }

        /// <summary>
        /// Capacity of the RAM in gigabytes
        /// </summary>
        /// <value>Capacity of the RAM in gigabytes</value>
        /// <example>16</example>
        [DataMember(Name = "ramGb", EmitDefaultValue = false)]
        public int RamGb { get; set; }

        /// <summary>
        /// Capacity of the volume in gigabytes
        /// </summary>
        /// <value>Capacity of the volume in gigabytes</value>
        /// <example>500</example>
        [DataMember(Name = "volumeGb", EmitDefaultValue = false)]
        public int VolumeGb { get; set; }

        /// <summary>
        /// Volume type
        /// </summary>
        /// <value>Volume type</value>
        /// <example>SSD</example>
        [DataMember(Name = "volumeType", EmitDefaultValue = false)]
        public string VolumeType { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public VmConfigurationCost Cost { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VmConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  DataCenterId: ").Append(DataCenterId).Append("\n");
            sb.Append("  DataCenterName: ").Append(DataCenterName).Append("\n");
            sb.Append("  OsId: ").Append(OsId).Append("\n");
            sb.Append("  OsType: ").Append(OsType).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  CloudNetworkTypes: ").Append(CloudNetworkTypes).Append("\n");
            sb.Append("  VCpuType: ").Append(VCpuType).Append("\n");
            sb.Append("  VCpu: ").Append(VCpu).Append("\n");
            sb.Append("  RamGb: ").Append(RamGb).Append("\n");
            sb.Append("  VolumeGb: ").Append(VolumeGb).Append("\n");
            sb.Append("  VolumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
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