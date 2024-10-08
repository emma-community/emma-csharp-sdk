/*
 * Public EMMA API
 *
 * ### About Infrastructure API  **Base URL:** **<u>https://api.emma.ms/external</u>**   This **Infrastructure API** is for managing the emma cloud infrastructure within a project. The API enables you to view, create, edit, and delete _Virtual machines, Spot instances, Applications, Kubernetes clusters, SSH keys, Security groups, and Backup policies_. For creating the resources you can use the endpoints with the dictionaries: _Data centers, Locations, Providers, Operating systems, Virtual machines configurations, Spot instances configurations, Kubernetes clusters configurations._   ### Authentication   #### 1. Create service application   To access the API, enter your project, navigate to **Settings** > **Service Apps**, and create a service application. Select the access level **Read**, **Operate**, or **Manage**.   - **Read** - only GET methods are allowed in the API.   - **Operate** - some operations are allowed with the resources (e.g. _Start, Reboot,_ and _Shutdown_ of the Virtual machines).   - **Manage** - full creating, updating, and deleting of the resources is allowed.    #### 2. Get access token   - Copy the **Client ID** and **Client Secret** in the service application.  - Send an API request to the endpoint **_/issue-token** as specified in the **Authentication** section of the API documentation. You will receive access and refresh tokens in the response.   _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token \\  -H \"Content-Type: application/json\" \\  -d '{\"clientId\": \"YOUR-CLIENT-ID\", \"clientSecret\": \"YOUR-CLIENT-SECRET\"}'  ```  _For Windows:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token ^  -H \"Content-Type: application/json\" ^  -d \"{\\\"clientId\\\": \\\"YOUR-CLIENT-ID\\\", \\\"clientSecret\\\": \\\"YOUR-CLIENT-SECRET\\\"}\"  ```   #### 3. Use access token in requests  The Bearer access token is a text string, included in the request header, for example:   _For Linux / Mac:_  ```  curl -X GET https://api.emma.ms/external/v1/locations -H \"Authorization: Bearer YOUR-ACCESS-TOKEN-HERE\"  ```   Use this token for the API requests.    #### 4. Refresh token  The access token will expire in 10 minutes. A new access token may be created using the refresh token (without Client ID and Client Secret).   To get a new access token send a request to the **_/refresh-token** endpoint:    _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/refresh-token \\  -H \"Content-Type: application/json\" \\  -d '{\"refreshToken\": \"YOUR-REFRESH-TOKEN\"}'  ```       ### Possible response status codes   We use standard HTTP response codes to show the success or failure of requests.   `2xx` - successful responses.   `4xx` - client error responses (the response contains an explanation of the error).   `5xx` - server error responses.   The API uses the following status codes:   | Status Code | Description                  | Notes                                                                  |  |- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|  | 200         | OK                           | The request was successful.                                             |  | 201         | Created                      | The object was successfully created. This code is only used with objects that are created immediately.  | 204         | No content                   | A successful request, but there is no additional information to send back in the response body (in a case when the object was deleted).    | 400         | Bad Request                  | The request could not be understood by the server. Incoming parameters might not be valid. |  | 401         | Unauthorized            | The client is unauthenticated. The client must authenticate itself to get the requested response. |  | 403         | Forbidden                   | The client does not have access rights to the content.  | 404         | Not Found                    | The requested resource is not found.                                    |  | 409         | Conflict | This response is sent when a request conflicts with the current state of the object (e.g. deleting the security group with the compute instances in it).|  | 422         | Unprocessable Content   | The request was well-formed but was unable to be followed due to incorrect field values (e.g. creation of a virtual machine in the non-existent data center).  |  | 500         | Internal server Error                 | The server could not return the representation due to an internal server error. | 
 *
 * The version of the OpenAPI document: 1.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing ComputeInstancesConfigurationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ComputeInstancesConfigurationsApiTests : IDisposable
    {
        private ComputeInstancesConfigurationsApi instance;

        public ComputeInstancesConfigurationsApiTests()
        {
            instance = new ComputeInstancesConfigurationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ComputeInstancesConfigurationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ComputeInstancesConfigurationsApi
            //Assert.IsType<ComputeInstancesConfigurationsApi>(instance);
        }

        /// <summary>
        /// Test GetKuberNodesConfigs
        /// </summary>
        [Fact]
        public void GetKuberNodesConfigsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? providerId = null;
            //int? locationId = null;
            //string? dataCenterId = null;
            //string? vCpuType = null;
            //int? vCpu = null;
            //int? vCpuMin = null;
            //int? vCpuMax = null;
            //int? ramGb = null;
            //int? ramGbMin = null;
            //int? ramGbMax = null;
            //int? volumeGb = null;
            //int? volumeGbMin = null;
            //int? volumeGbMax = null;
            //string? volumeType = null;
            //decimal? priceMin = null;
            //decimal? priceMax = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetKuberNodesConfigs(providerId, locationId, dataCenterId, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
            //Assert.IsType<GetVmConfigs200Response>(response);
        }

        /// <summary>
        /// Test GetSpotConfigs
        /// </summary>
        [Fact]
        public void GetSpotConfigsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? providerId = null;
            //int? locationId = null;
            //string? dataCenterId = null;
            //string? cloudNetworkType = null;
            //string? vCpuType = null;
            //int? vCpu = null;
            //int? vCpuMin = null;
            //int? vCpuMax = null;
            //int? ramGb = null;
            //int? ramGbMin = null;
            //int? ramGbMax = null;
            //int? volumeGb = null;
            //int? volumeGbMin = null;
            //int? volumeGbMax = null;
            //string? volumeType = null;
            //decimal? priceMin = null;
            //decimal? priceMax = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetSpotConfigs(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
            //Assert.IsType<GetVmConfigs200Response>(response);
        }

        /// <summary>
        /// Test GetVmConfigs
        /// </summary>
        [Fact]
        public void GetVmConfigsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? providerId = null;
            //int? locationId = null;
            //string? dataCenterId = null;
            //string? cloudNetworkType = null;
            //string? vCpuType = null;
            //int? vCpu = null;
            //int? vCpuMin = null;
            //int? vCpuMax = null;
            //int? ramGb = null;
            //int? ramGbMin = null;
            //int? ramGbMax = null;
            //int? volumeGb = null;
            //int? volumeGbMin = null;
            //int? volumeGbMax = null;
            //string? volumeType = null;
            //decimal? priceMin = null;
            //decimal? priceMax = null;
            //int? page = null;
            //int? size = null;
            //var response = instance.GetVmConfigs(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
            //Assert.IsType<GetVmConfigs200Response>(response);
        }
    }
}
