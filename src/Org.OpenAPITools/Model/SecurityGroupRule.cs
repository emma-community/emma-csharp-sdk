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
    /// SecurityGroupRule
    /// </summary>
    [DataContract(Name = "SecurityGroupRule")]
    public partial class SecurityGroupRule : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityGroupRule" /> class.
        /// </summary>
        /// <param name="type">Type of the security group rule.</param>
        /// <param name="policy">Rule policy (all rules are allowing).</param>
        /// <param name="direction">Direction of the network traffic: inbound or outbound. .</param>
        /// <param name="protocol">Network protocol of the rule.</param>
        /// <param name="ports">Allowed port or port range.</param>
        /// <param name="ipRange">Allowed IP or IP range.</param>
        /// <param name="isMutable">Indicates if the rule can be edited. Some security group rules are added by default, cannot be changed, and are marked as immutable..</param>
        public SecurityGroupRule(string type = default(string), string policy = default(string), string direction = default(string), string protocol = default(string), string ports = default(string), string ipRange = default(string), bool isMutable = default(bool))
        {
            this.Type = type;
            this.Policy = policy;
            this.Direction = direction;
            this.Protocol = protocol;
            this.Ports = ports;
            this.IpRange = ipRange;
            this.IsMutable = isMutable;
        }

        /// <summary>
        /// Type of the security group rule
        /// </summary>
        /// <value>Type of the security group rule</value>
        /// <example>Custom TCP</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Rule policy (all rules are allowing)
        /// </summary>
        /// <value>Rule policy (all rules are allowing)</value>
        /// <example>ALLOW</example>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public string Policy { get; set; }

        /// <summary>
        /// Direction of the network traffic: inbound or outbound. 
        /// </summary>
        /// <value>Direction of the network traffic: inbound or outbound. </value>
        /// <example>INBOUND</example>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public string Direction { get; set; }

        /// <summary>
        /// Network protocol of the rule
        /// </summary>
        /// <value>Network protocol of the rule</value>
        /// <example>TCP</example>
        [DataMember(Name = "protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Allowed port or port range
        /// </summary>
        /// <value>Allowed port or port range</value>
        /// <example>30321</example>
        [DataMember(Name = "ports", EmitDefaultValue = false)]
        public string Ports { get; set; }

        /// <summary>
        /// Allowed IP or IP range
        /// </summary>
        /// <value>Allowed IP or IP range</value>
        /// <example>0.0.0.0/0</example>
        [DataMember(Name = "ipRange", EmitDefaultValue = false)]
        public string IpRange { get; set; }

        /// <summary>
        /// Indicates if the rule can be edited. Some security group rules are added by default, cannot be changed, and are marked as immutable.
        /// </summary>
        /// <value>Indicates if the rule can be edited. Some security group rules are added by default, cannot be changed, and are marked as immutable.</value>
        /// <example>true</example>
        [DataMember(Name = "isMutable", EmitDefaultValue = true)]
        public bool IsMutable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityGroupRule {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  IpRange: ").Append(IpRange).Append("\n");
            sb.Append("  IsMutable: ").Append(IsMutable).Append("\n");
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
