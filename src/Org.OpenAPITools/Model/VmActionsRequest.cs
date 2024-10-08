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
using System.Reflection;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// VmActionsRequest
    /// </summary>
    [JsonConverter(typeof(VmActionsRequestJsonConverter))]
    [DataContract(Name = "VmActions_request")]
    public partial class VmActionsRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmStart" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmStart.</param>
        public VmActionsRequest(VmStart actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmShutdown" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmShutdown.</param>
        public VmActionsRequest(VmShutdown actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmReboot" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmReboot.</param>
        public VmActionsRequest(VmReboot actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmTransfer" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmTransfer.</param>
        public VmActionsRequest(VmTransfer actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmClone" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmClone.</param>
        public VmActionsRequest(VmClone actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VmActionsRequest" /> class
        /// with the <see cref="VmEditHardware" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmEditHardware.</param>
        public VmActionsRequest(VmEditHardware actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(VmClone) || value is VmClone)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmEditHardware) || value is VmEditHardware)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmReboot) || value is VmReboot)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmShutdown) || value is VmShutdown)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmStart) || value is VmStart)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmTransfer) || value is VmTransfer)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: VmClone, VmEditHardware, VmReboot, VmShutdown, VmStart, VmTransfer");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `VmStart`. If the actual instance is not `VmStart`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmStart</returns>
        public VmStart GetVmStart()
        {
            return (VmStart)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmShutdown`. If the actual instance is not `VmShutdown`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmShutdown</returns>
        public VmShutdown GetVmShutdown()
        {
            return (VmShutdown)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmReboot`. If the actual instance is not `VmReboot`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmReboot</returns>
        public VmReboot GetVmReboot()
        {
            return (VmReboot)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmTransfer`. If the actual instance is not `VmTransfer`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmTransfer</returns>
        public VmTransfer GetVmTransfer()
        {
            return (VmTransfer)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmClone`. If the actual instance is not `VmClone`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmClone</returns>
        public VmClone GetVmClone()
        {
            return (VmClone)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmEditHardware`. If the actual instance is not `VmEditHardware`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmEditHardware</returns>
        public VmEditHardware GetVmEditHardware()
        {
            return (VmEditHardware)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmActionsRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, VmActionsRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of VmActionsRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of VmActionsRequest</returns>
        public static VmActionsRequest FromJson(string jsonString)
        {
            VmActionsRequest newVmActionsRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newVmActionsRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmClone).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmClone>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmClone>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmClone");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmClone: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmEditHardware).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmEditHardware>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmEditHardware>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmEditHardware");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmEditHardware: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmReboot).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmReboot>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmReboot>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmReboot");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmReboot: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmShutdown).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmShutdown>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmShutdown>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmShutdown");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmShutdown: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmStart).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmStart>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmStart>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmStart");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmStart: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmTransfer).GetProperty("AdditionalProperties") == null)
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmTransfer>(jsonString, VmActionsRequest.SerializerSettings));
                }
                else
                {
                    newVmActionsRequest = new VmActionsRequest(JsonConvert.DeserializeObject<VmTransfer>(jsonString, VmActionsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmTransfer");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmTransfer: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newVmActionsRequest;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for VmActionsRequest
    /// </summary>
    public class VmActionsRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(VmActionsRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return VmActionsRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return VmActionsRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}