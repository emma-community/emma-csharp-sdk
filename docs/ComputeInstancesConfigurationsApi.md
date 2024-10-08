# Org.OpenAPITools.Api.ComputeInstancesConfigurationsApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetKuberNodesConfigs**](ComputeInstancesConfigurationsApi.md#getkubernodesconfigs) | **GET** /v1/kubernetes-configs | List of available configurations for Kubernetes cluster node |
| [**GetSpotConfigs**](ComputeInstancesConfigurationsApi.md#getspotconfigs) | **GET** /v1/spots-configs | List of available configurations for spot instance creation |
| [**GetVmConfigs**](ComputeInstancesConfigurationsApi.md#getvmconfigs) | **GET** /v1/vms-configs | List of available configurations for virtual machine creation |

<a id="getkubernodesconfigs"></a>
# **GetKuberNodesConfigs**
> GetVmConfigs200Response GetKuberNodesConfigs (int? providerId = null, int? locationId = null, string? dataCenterId = null, string? vCpuType = null, int? vCpu = null, int? vCpuMin = null, int? vCpuMax = null, int? ramGb = null, int? ramGbMin = null, int? ramGbMax = null, int? volumeGb = null, int? volumeGbMin = null, int? volumeGbMax = null, string? volumeType = null, decimal? priceMin = null, decimal? priceMax = null, int? page = null, int? size = null)

List of available configurations for Kubernetes cluster node

When creating Kubernetes clusters you need to provide the desired hardware configurations for working nodes. These configurations include CPU, CPU type, RAM, volume size, and volume type. Different cloud providers offer various configurations in different data centers. Therefore, before creating any compute instance, you need to verify the available configurations.  Use this endpoint as a reference for available configurations for working nodes. You can search the available configurations by different parameters (provider, location, data center, CPU, CPU type, RAM, volume size, volume type, and price).  When you find an appropriate configuration, provide the hardware parameters in the endpoint for creating or editing a Kubernetes cluster. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetKuberNodesConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputeInstancesConfigurationsApi(config);
            var providerId = 5;  // int? | ID of the cloud provider (optional) 
            var locationId = 6;  // int? | ID of the geographic location (optional) 
            var dataCenterId = aws-us-west-1;  // string? | ID of the cloud provider's data center (optional) 
            var vCpuType = Standard;  // string? | Type of vCPUs for the compute instance (optional) 
            var vCpu = 4;  // int? | virtual Central Processing Units (vCPUs) for the compute instance (optional) 
            var vCpuMin = 1;  // int? | Minimum number of vCPUs for the compute instance (optional) 
            var vCpuMax = 8;  // int? | Maximum number of vCPUs for the compute instance (optional) 
            var ramGb = 16;  // int? | RAM of the compute instance in gigabytes (optional) 
            var ramGbMin = 8;  // int? | Minimum RAM of the compute instance in gigabytes (optional) 
            var ramGbMax = 32;  // int? | Maximum RAM of the compute instance in gigabytes (optional) 
            var volumeGb = 500;  // int? | Volume size of the compute instance in gigabytes (optional) 
            var volumeGbMin = 250;  // int? | Minimum volume size of the compute instance in gigabytes (optional) 
            var volumeGbMax = 1000;  // int? | Maximum volume size of the compute instance in gigabytes (optional) 
            var volumeType = ssd;  // string? | Volume type of the compute instance (optional) 
            var priceMin = 8.14D;  // decimal? | Minimum price of the compute instance (optional) 
            var priceMax = 8.14D;  // decimal? | Maximum price of the compute instance (optional) 
            var page = 0;  // int? | Page number (optional) 
            var size = 100;  // int? | Query size (optional) 

            try
            {
                // List of available configurations for Kubernetes cluster node
                GetVmConfigs200Response result = apiInstance.GetKuberNodesConfigs(providerId, locationId, dataCenterId, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetKuberNodesConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetKuberNodesConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of available configurations for Kubernetes cluster node
    ApiResponse<GetVmConfigs200Response> response = apiInstance.GetKuberNodesConfigsWithHttpInfo(providerId, locationId, dataCenterId, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetKuberNodesConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int?** | ID of the cloud provider | [optional]  |
| **locationId** | **int?** | ID of the geographic location | [optional]  |
| **dataCenterId** | **string?** | ID of the cloud provider&#39;s data center | [optional]  |
| **vCpuType** | **string?** | Type of vCPUs for the compute instance | [optional]  |
| **vCpu** | **int?** | virtual Central Processing Units (vCPUs) for the compute instance | [optional]  |
| **vCpuMin** | **int?** | Minimum number of vCPUs for the compute instance | [optional]  |
| **vCpuMax** | **int?** | Maximum number of vCPUs for the compute instance | [optional]  |
| **ramGb** | **int?** | RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMin** | **int?** | Minimum RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMax** | **int?** | Maximum RAM of the compute instance in gigabytes | [optional]  |
| **volumeGb** | **int?** | Volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMin** | **int?** | Minimum volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMax** | **int?** | Maximum volume size of the compute instance in gigabytes | [optional]  |
| **volumeType** | **string?** | Volume type of the compute instance | [optional]  |
| **priceMin** | **decimal?** | Minimum price of the compute instance | [optional]  |
| **priceMax** | **decimal?** | Maximum price of the compute instance | [optional]  |
| **page** | **int?** | Page number | [optional]  |
| **size** | **int?** | Query size | [optional]  |

### Return type

[**GetVmConfigs200Response**](GetVmConfigs200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getspotconfigs"></a>
# **GetSpotConfigs**
> GetVmConfigs200Response GetSpotConfigs (int? providerId = null, int? locationId = null, string? dataCenterId = null, string? cloudNetworkType = null, string? vCpuType = null, int? vCpu = null, int? vCpuMin = null, int? vCpuMax = null, int? ramGb = null, int? ramGbMin = null, int? ramGbMax = null, int? volumeGb = null, int? volumeGbMin = null, int? volumeGbMax = null, string? volumeType = null, decimal? priceMin = null, decimal? priceMax = null, int? page = null, int? size = null)

List of available configurations for spot instance creation

When creating spot instances you need to provide the desired hardware configurations. These configurations include CPU, CPU type, RAM, volume size, and volume type. Different cloud providers offer various configurations in different data centers. Therefore, before creating any compute instance, you need to verify the available configurations.  Use this endpoint as a reference for available configurations for spot instances. You can search the available configurations by different parameters (provider, location, data center, cloud network type, CPU, CPU type, RAM, volume size, volume type, and price).  When you find an appropriate configuration, provide the hardware parameters in the endpoint for creating or editing a spot instance. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSpotConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputeInstancesConfigurationsApi(config);
            var providerId = 5;  // int? | ID of the cloud provider (optional) 
            var locationId = 6;  // int? | ID of the geographic location (optional) 
            var dataCenterId = aws-us-west-1;  // string? | ID of the cloud provider's data center (optional) 
            var cloudNetworkType = multi-cloud;  // string? | Type of cloud network (optional) 
            var vCpuType = Standard;  // string? | Type of vCPUs for the compute instance (optional) 
            var vCpu = 4;  // int? | virtual Central Processing Units (vCPUs) for the compute instance (optional) 
            var vCpuMin = 1;  // int? | Minimum number of vCPUs for the compute instance (optional) 
            var vCpuMax = 8;  // int? | Maximum number of vCPUs for the compute instance (optional) 
            var ramGb = 16;  // int? | RAM of the compute instance in gigabytes (optional) 
            var ramGbMin = 8;  // int? | Minimum RAM of the compute instance in gigabytes (optional) 
            var ramGbMax = 32;  // int? | Maximum RAM of the compute instance in gigabytes (optional) 
            var volumeGb = 500;  // int? | Volume size of the compute instance in gigabytes (optional) 
            var volumeGbMin = 250;  // int? | Minimum volume size of the compute instance in gigabytes (optional) 
            var volumeGbMax = 1000;  // int? | Maximum volume size of the compute instance in gigabytes (optional) 
            var volumeType = ssd;  // string? | Volume type of the compute instance (optional) 
            var priceMin = 8.14D;  // decimal? | Minimum price of the compute instance (optional) 
            var priceMax = 8.14D;  // decimal? | Maximum price of the compute instance (optional) 
            var page = 0;  // int? | Page number (optional) 
            var size = 100;  // int? | Query size (optional) 

            try
            {
                // List of available configurations for spot instance creation
                GetVmConfigs200Response result = apiInstance.GetSpotConfigs(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetSpotConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSpotConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of available configurations for spot instance creation
    ApiResponse<GetVmConfigs200Response> response = apiInstance.GetSpotConfigsWithHttpInfo(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetSpotConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int?** | ID of the cloud provider | [optional]  |
| **locationId** | **int?** | ID of the geographic location | [optional]  |
| **dataCenterId** | **string?** | ID of the cloud provider&#39;s data center | [optional]  |
| **cloudNetworkType** | **string?** | Type of cloud network | [optional]  |
| **vCpuType** | **string?** | Type of vCPUs for the compute instance | [optional]  |
| **vCpu** | **int?** | virtual Central Processing Units (vCPUs) for the compute instance | [optional]  |
| **vCpuMin** | **int?** | Minimum number of vCPUs for the compute instance | [optional]  |
| **vCpuMax** | **int?** | Maximum number of vCPUs for the compute instance | [optional]  |
| **ramGb** | **int?** | RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMin** | **int?** | Minimum RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMax** | **int?** | Maximum RAM of the compute instance in gigabytes | [optional]  |
| **volumeGb** | **int?** | Volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMin** | **int?** | Minimum volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMax** | **int?** | Maximum volume size of the compute instance in gigabytes | [optional]  |
| **volumeType** | **string?** | Volume type of the compute instance | [optional]  |
| **priceMin** | **decimal?** | Minimum price of the compute instance | [optional]  |
| **priceMax** | **decimal?** | Maximum price of the compute instance | [optional]  |
| **page** | **int?** | Page number | [optional]  |
| **size** | **int?** | Query size | [optional]  |

### Return type

[**GetVmConfigs200Response**](GetVmConfigs200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvmconfigs"></a>
# **GetVmConfigs**
> GetVmConfigs200Response GetVmConfigs (int? providerId = null, int? locationId = null, string? dataCenterId = null, string? cloudNetworkType = null, string? vCpuType = null, int? vCpu = null, int? vCpuMin = null, int? vCpuMax = null, int? ramGb = null, int? ramGbMin = null, int? ramGbMax = null, int? volumeGb = null, int? volumeGbMin = null, int? volumeGbMax = null, string? volumeType = null, decimal? priceMin = null, decimal? priceMax = null, int? page = null, int? size = null)

List of available configurations for virtual machine creation

When creating virtual machines you need to provide the desired hardware configurations. These configurations include CPU, CPU type, RAM, volume size, and volume type. Different cloud providers offer various configurations in different data centers. Therefore, before creating any compute instance, you need to verify the available configurations.  Use this endpoint as a reference for available configurations for virtual machines. You can search the available configurations by different parameters (provider, location, data center, cloud network type, CPU, CPU type, RAM, volume size, volume type, and price).  When you find an appropriate configuration, provide the hardware parameters in the endpoint for creating or editing a virtual machine. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVmConfigsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ComputeInstancesConfigurationsApi(config);
            var providerId = 5;  // int? | ID of the cloud provider (optional) 
            var locationId = 6;  // int? | ID of the geographic location (optional) 
            var dataCenterId = aws-us-west-1;  // string? | ID of the cloud provider's data center (optional) 
            var cloudNetworkType = multi-cloud;  // string? | Type of cloud network (optional) 
            var vCpuType = Standard;  // string? | Type of vCPUs for the compute instance (optional) 
            var vCpu = 4;  // int? | virtual Central Processing Units (vCPUs) for the compute instance (optional) 
            var vCpuMin = 1;  // int? | Minimum number of vCPUs for the compute instance (optional) 
            var vCpuMax = 8;  // int? | Maximum number of vCPUs for the compute instance (optional) 
            var ramGb = 16;  // int? | RAM of the compute instance in gigabytes (optional) 
            var ramGbMin = 8;  // int? | Minimum RAM of the compute instance in gigabytes (optional) 
            var ramGbMax = 32;  // int? | Maximum RAM of the compute instance in gigabytes (optional) 
            var volumeGb = 500;  // int? | Volume size of the compute instance in gigabytes (optional) 
            var volumeGbMin = 250;  // int? | Minimum volume size of the compute instance in gigabytes (optional) 
            var volumeGbMax = 1000;  // int? | Maximum volume size of the compute instance in gigabytes (optional) 
            var volumeType = ssd;  // string? | Volume type of the compute instance (optional) 
            var priceMin = 8.14D;  // decimal? | Minimum price of the compute instance (optional) 
            var priceMax = 8.14D;  // decimal? | Maximum price of the compute instance (optional) 
            var page = 0;  // int? | Page number (optional) 
            var size = 100;  // int? | Query size (optional) 

            try
            {
                // List of available configurations for virtual machine creation
                GetVmConfigs200Response result = apiInstance.GetVmConfigs(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetVmConfigs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVmConfigsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of available configurations for virtual machine creation
    ApiResponse<GetVmConfigs200Response> response = apiInstance.GetVmConfigsWithHttpInfo(providerId, locationId, dataCenterId, cloudNetworkType, vCpuType, vCpu, vCpuMin, vCpuMax, ramGb, ramGbMin, ramGbMax, volumeGb, volumeGbMin, volumeGbMax, volumeType, priceMin, priceMax, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ComputeInstancesConfigurationsApi.GetVmConfigsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **int?** | ID of the cloud provider | [optional]  |
| **locationId** | **int?** | ID of the geographic location | [optional]  |
| **dataCenterId** | **string?** | ID of the cloud provider&#39;s data center | [optional]  |
| **cloudNetworkType** | **string?** | Type of cloud network | [optional]  |
| **vCpuType** | **string?** | Type of vCPUs for the compute instance | [optional]  |
| **vCpu** | **int?** | virtual Central Processing Units (vCPUs) for the compute instance | [optional]  |
| **vCpuMin** | **int?** | Minimum number of vCPUs for the compute instance | [optional]  |
| **vCpuMax** | **int?** | Maximum number of vCPUs for the compute instance | [optional]  |
| **ramGb** | **int?** | RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMin** | **int?** | Minimum RAM of the compute instance in gigabytes | [optional]  |
| **ramGbMax** | **int?** | Maximum RAM of the compute instance in gigabytes | [optional]  |
| **volumeGb** | **int?** | Volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMin** | **int?** | Minimum volume size of the compute instance in gigabytes | [optional]  |
| **volumeGbMax** | **int?** | Maximum volume size of the compute instance in gigabytes | [optional]  |
| **volumeType** | **string?** | Volume type of the compute instance | [optional]  |
| **priceMin** | **decimal?** | Minimum price of the compute instance | [optional]  |
| **priceMax** | **decimal?** | Maximum price of the compute instance | [optional]  |
| **page** | **int?** | Page number | [optional]  |
| **size** | **int?** | Query size | [optional]  |

### Return type

[**GetVmConfigs200Response**](GetVmConfigs200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

