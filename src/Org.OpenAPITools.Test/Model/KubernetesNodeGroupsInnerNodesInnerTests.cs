/*
 * Public EMMA API
 *
 * ### About Infrastructure API  **Base URL:** **<u>https://api.emma.ms/external</u>**   This **Infrastructure API** is for managing the emma cloud infrastructure within a project. The API enables you to view, create, edit, and delete _Virtual machines, Spot instances, Applications, Kubernetes clusters, SSH keys, Security groups, and Backup policies_. For creating the resources you can use the endpoints with the dictionaries: _Data centers, Locations, Providers, Operating systems, Virtual machines configurations, Spot instances configurations, Kubernetes clusters configurations._   ### Authentication   #### 1. Create service application   To access the API, enter your project, navigate to **Settings** > **Service Apps**, and create a service application. Select the access level **Read**, **Operate**, or **Manage**.   - **Read** - only GET methods are allowed in the API.   - **Operate** - some operations are allowed with the resources (e.g. _Start, Reboot,_ and _Shutdown_ of the Virtual machines).   - **Manage** - full creating, updating, and deleting of the resources is allowed.    #### 2. Get access token   - Copy the **Client ID** and **Client Secret** in the service application.  - Send an API request to the endpoint **_/issue-token** as specified in the **Authentication** section of the API documentation. You will receive access and refresh tokens in the response.   _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token \\  -H \"Content-Type: application/json\" \\  -d '{\"clientId\": \"YOUR-CLIENT-ID\", \"clientSecret\": \"YOUR-CLIENT-SECRET\"}'  ```  _For Windows:_  ```  curl -X POST https://api.emma.ms/external/v1/issue-token ^  -H \"Content-Type: application/json\" ^  -d \"{\\\"clientId\\\": \\\"YOUR-CLIENT-ID\\\", \\\"clientSecret\\\": \\\"YOUR-CLIENT-SECRET\\\"}\"  ```   #### 3. Use access token in requests  The Bearer access token is a text string, included in the request header, for example:   _For Linux / Mac:_  ```  curl -X GET https://api.emma.ms/external/v1/locations -H \"Authorization: Bearer YOUR-ACCESS-TOKEN-HERE\"  ```   Use this token for the API requests.    #### 4. Refresh token  The access token will expire in 10 minutes. A new access token may be created using the refresh token (without Client ID and Client Secret).   To get a new access token send a request to the **_/refresh-token** endpoint:    _For Linux / Mac:_  ```  curl -X POST https://api.emma.ms/external/v1/refresh-token \\  -H \"Content-Type: application/json\" \\  -d '{\"refreshToken\": \"YOUR-REFRESH-TOKEN\"}'  ```       ### Possible response status codes   We use standard HTTP response codes to show the success or failure of requests.   `2xx` - successful responses.   `4xx` - client error responses (the response contains an explanation of the error).   `5xx` - server error responses.   The API uses the following status codes:   | Status Code | Description                  | Notes                                                                  |  |- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|  | 200         | OK                           | The request was successful.                                             |  | 201         | Created                      | The object was successfully created. This code is only used with objects that are created immediately.  | 204         | No content                   | A successful request, but there is no additional information to send back in the response body (in a case when the object was deleted).    | 400         | Bad Request                  | The request could not be understood by the server. Incoming parameters might not be valid. |  | 401         | Unauthorized            | The client is unauthenticated. The client must authenticate itself to get the requested response. |  | 403         | Forbidden                   | The client does not have access rights to the content.  | 404         | Not Found                    | The requested resource is not found.                                    |  | 409         | Conflict | This response is sent when a request conflicts with the current state of the object (e.g. deleting the security group with the compute instances in it).|  | 422         | Unprocessable Content   | The request was well-formed but was unable to be followed due to incorrect field values (e.g. creation of a virtual machine in the non-existent data center).  |  | 500         | Internal server Error                 | The server could not return the representation due to an internal server error. | 
 *
 * The version of the OpenAPI document: 1.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing KubernetesNodeGroupsInnerNodesInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KubernetesNodeGroupsInnerNodesInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KubernetesNodeGroupsInnerNodesInner
        //private KubernetesNodeGroupsInnerNodesInner instance;

        public KubernetesNodeGroupsInnerNodesInnerTests()
        {
            // TODO uncomment below to create an instance of KubernetesNodeGroupsInnerNodesInner
            //instance = new KubernetesNodeGroupsInnerNodesInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KubernetesNodeGroupsInnerNodesInner
        /// </summary>
        [Fact]
        public void KubernetesNodeGroupsInnerNodesInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" KubernetesNodeGroupsInnerNodesInner
            //Assert.IsType<KubernetesNodeGroupsInnerNodesInner>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'Provider'
        /// </summary>
        [Fact]
        public void ProviderTest()
        {
            // TODO unit test for the property 'Provider'
        }

        /// <summary>
        /// Test the property 'Location'
        /// </summary>
        [Fact]
        public void LocationTest()
        {
            // TODO unit test for the property 'Location'
        }

        /// <summary>
        /// Test the property 'DataCenter'
        /// </summary>
        [Fact]
        public void DataCenterTest()
        {
            // TODO unit test for the property 'DataCenter'
        }

        /// <summary>
        /// Test the property 'Os'
        /// </summary>
        [Fact]
        public void OsTest()
        {
            // TODO unit test for the property 'Os'
        }

        /// <summary>
        /// Test the property 'VCpu'
        /// </summary>
        [Fact]
        public void VCpuTest()
        {
            // TODO unit test for the property 'VCpu'
        }

        /// <summary>
        /// Test the property 'VCpuType'
        /// </summary>
        [Fact]
        public void VCpuTypeTest()
        {
            // TODO unit test for the property 'VCpuType'
        }

        /// <summary>
        /// Test the property 'CloudNetworkType'
        /// </summary>
        [Fact]
        public void CloudNetworkTypeTest()
        {
            // TODO unit test for the property 'CloudNetworkType'
        }

        /// <summary>
        /// Test the property 'RamGb'
        /// </summary>
        [Fact]
        public void RamGbTest()
        {
            // TODO unit test for the property 'RamGb'
        }

        /// <summary>
        /// Test the property 'Disks'
        /// </summary>
        [Fact]
        public void DisksTest()
        {
            // TODO unit test for the property 'Disks'
        }

        /// <summary>
        /// Test the property 'Networks'
        /// </summary>
        [Fact]
        public void NetworksTest()
        {
            // TODO unit test for the property 'Networks'
        }

        /// <summary>
        /// Test the property 'SecurityGroup'
        /// </summary>
        [Fact]
        public void SecurityGroupTest()
        {
            // TODO unit test for the property 'SecurityGroup'
        }

        /// <summary>
        /// Test the property 'Cost'
        /// </summary>
        [Fact]
        public void CostTest()
        {
            // TODO unit test for the property 'Cost'
        }
    }
}
