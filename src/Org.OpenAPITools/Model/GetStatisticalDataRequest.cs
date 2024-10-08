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
    /// GetStatisticalDataRequest
    /// </summary>
    [JsonConverter(typeof(GetStatisticalDataRequestJsonConverter))]
    [DataContract(Name = "GetStatisticalData_request")]
    public partial class GetStatisticalDataRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="CostAnalysisQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CostAnalysisQuery.</param>
        public GetStatisticalDataRequest(CostAnalysisQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="KubernetesClusterChangingMetricsQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KubernetesClusterChangingMetricsQuery.</param>
        public GetStatisticalDataRequest(KubernetesClusterChangingMetricsQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="KubernetesClusterCurrentStateQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KubernetesClusterCurrentStateQuery.</param>
        public GetStatisticalDataRequest(KubernetesClusterCurrentStateQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="KubernetesClusterMetricsQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KubernetesClusterMetricsQuery.</param>
        public GetStatisticalDataRequest(KubernetesClusterMetricsQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="KubernetesClusterObjectsQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KubernetesClusterObjectsQuery.</param>
        public GetStatisticalDataRequest(KubernetesClusterObjectsQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="KubernetesClusterObjectStatesQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KubernetesClusterObjectStatesQuery.</param>
        public GetStatisticalDataRequest(KubernetesClusterObjectStatesQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="ProductStatisticsQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProductStatisticsQuery.</param>
        public GetStatisticalDataRequest(ProductStatisticsQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="ProjectSummaryQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ProjectSummaryQuery.</param>
        public GetStatisticalDataRequest(ProjectSummaryQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="ResourceAnalysisQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ResourceAnalysisQuery.</param>
        public GetStatisticalDataRequest(ResourceAnalysisQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="VmMonitoringQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmMonitoringQuery.</param>
        public GetStatisticalDataRequest(VmMonitoringQuery actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticalDataRequest" /> class
        /// with the <see cref="VmAnalyticsQuery" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of VmAnalyticsQuery.</param>
        public GetStatisticalDataRequest(VmAnalyticsQuery actualInstance)
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
                if (value.GetType() == typeof(CostAnalysisQuery) || value is CostAnalysisQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KubernetesClusterChangingMetricsQuery) || value is KubernetesClusterChangingMetricsQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KubernetesClusterCurrentStateQuery) || value is KubernetesClusterCurrentStateQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KubernetesClusterMetricsQuery) || value is KubernetesClusterMetricsQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KubernetesClusterObjectStatesQuery) || value is KubernetesClusterObjectStatesQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KubernetesClusterObjectsQuery) || value is KubernetesClusterObjectsQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProductStatisticsQuery) || value is ProductStatisticsQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ProjectSummaryQuery) || value is ProjectSummaryQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(ResourceAnalysisQuery) || value is ResourceAnalysisQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmAnalyticsQuery) || value is VmAnalyticsQuery)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(VmMonitoringQuery) || value is VmMonitoringQuery)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CostAnalysisQuery, KubernetesClusterChangingMetricsQuery, KubernetesClusterCurrentStateQuery, KubernetesClusterMetricsQuery, KubernetesClusterObjectStatesQuery, KubernetesClusterObjectsQuery, ProductStatisticsQuery, ProjectSummaryQuery, ResourceAnalysisQuery, VmAnalyticsQuery, VmMonitoringQuery");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CostAnalysisQuery`. If the actual instance is not `CostAnalysisQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CostAnalysisQuery</returns>
        public CostAnalysisQuery GetCostAnalysisQuery()
        {
            return (CostAnalysisQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KubernetesClusterChangingMetricsQuery`. If the actual instance is not `KubernetesClusterChangingMetricsQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KubernetesClusterChangingMetricsQuery</returns>
        public KubernetesClusterChangingMetricsQuery GetKubernetesClusterChangingMetricsQuery()
        {
            return (KubernetesClusterChangingMetricsQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KubernetesClusterCurrentStateQuery`. If the actual instance is not `KubernetesClusterCurrentStateQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KubernetesClusterCurrentStateQuery</returns>
        public KubernetesClusterCurrentStateQuery GetKubernetesClusterCurrentStateQuery()
        {
            return (KubernetesClusterCurrentStateQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KubernetesClusterMetricsQuery`. If the actual instance is not `KubernetesClusterMetricsQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KubernetesClusterMetricsQuery</returns>
        public KubernetesClusterMetricsQuery GetKubernetesClusterMetricsQuery()
        {
            return (KubernetesClusterMetricsQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KubernetesClusterObjectsQuery`. If the actual instance is not `KubernetesClusterObjectsQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KubernetesClusterObjectsQuery</returns>
        public KubernetesClusterObjectsQuery GetKubernetesClusterObjectsQuery()
        {
            return (KubernetesClusterObjectsQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KubernetesClusterObjectStatesQuery`. If the actual instance is not `KubernetesClusterObjectStatesQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KubernetesClusterObjectStatesQuery</returns>
        public KubernetesClusterObjectStatesQuery GetKubernetesClusterObjectStatesQuery()
        {
            return (KubernetesClusterObjectStatesQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ProductStatisticsQuery`. If the actual instance is not `ProductStatisticsQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProductStatisticsQuery</returns>
        public ProductStatisticsQuery GetProductStatisticsQuery()
        {
            return (ProductStatisticsQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ProjectSummaryQuery`. If the actual instance is not `ProjectSummaryQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ProjectSummaryQuery</returns>
        public ProjectSummaryQuery GetProjectSummaryQuery()
        {
            return (ProjectSummaryQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `ResourceAnalysisQuery`. If the actual instance is not `ResourceAnalysisQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ResourceAnalysisQuery</returns>
        public ResourceAnalysisQuery GetResourceAnalysisQuery()
        {
            return (ResourceAnalysisQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmMonitoringQuery`. If the actual instance is not `VmMonitoringQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmMonitoringQuery</returns>
        public VmMonitoringQuery GetVmMonitoringQuery()
        {
            return (VmMonitoringQuery)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `VmAnalyticsQuery`. If the actual instance is not `VmAnalyticsQuery`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of VmAnalyticsQuery</returns>
        public VmAnalyticsQuery GetVmAnalyticsQuery()
        {
            return (VmAnalyticsQuery)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatisticalDataRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetStatisticalDataRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetStatisticalDataRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetStatisticalDataRequest</returns>
        public static GetStatisticalDataRequest FromJson(string jsonString)
        {
            GetStatisticalDataRequest newGetStatisticalDataRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetStatisticalDataRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CostAnalysisQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<CostAnalysisQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<CostAnalysisQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CostAnalysisQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CostAnalysisQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KubernetesClusterChangingMetricsQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterChangingMetricsQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterChangingMetricsQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KubernetesClusterChangingMetricsQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KubernetesClusterChangingMetricsQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KubernetesClusterCurrentStateQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterCurrentStateQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterCurrentStateQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KubernetesClusterCurrentStateQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KubernetesClusterCurrentStateQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KubernetesClusterMetricsQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterMetricsQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterMetricsQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KubernetesClusterMetricsQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KubernetesClusterMetricsQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KubernetesClusterObjectStatesQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterObjectStatesQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterObjectStatesQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KubernetesClusterObjectStatesQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KubernetesClusterObjectStatesQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KubernetesClusterObjectsQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterObjectsQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<KubernetesClusterObjectsQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KubernetesClusterObjectsQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KubernetesClusterObjectsQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ProductStatisticsQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ProductStatisticsQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ProductStatisticsQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ProductStatisticsQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProductStatisticsQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ProjectSummaryQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ProjectSummaryQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ProjectSummaryQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ProjectSummaryQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ProjectSummaryQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ResourceAnalysisQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ResourceAnalysisQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<ResourceAnalysisQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ResourceAnalysisQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ResourceAnalysisQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmAnalyticsQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<VmAnalyticsQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<VmAnalyticsQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmAnalyticsQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmAnalyticsQuery: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(VmMonitoringQuery).GetProperty("AdditionalProperties") == null)
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<VmMonitoringQuery>(jsonString, GetStatisticalDataRequest.SerializerSettings));
                }
                else
                {
                    newGetStatisticalDataRequest = new GetStatisticalDataRequest(JsonConvert.DeserializeObject<VmMonitoringQuery>(jsonString, GetStatisticalDataRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("VmMonitoringQuery");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into VmMonitoringQuery: {1}", jsonString, exception.ToString()));
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
            return newGetStatisticalDataRequest;
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
    /// Custom JSON converter for GetStatisticalDataRequest
    /// </summary>
    public class GetStatisticalDataRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetStatisticalDataRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return GetStatisticalDataRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return GetStatisticalDataRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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