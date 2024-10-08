# Org.OpenAPITools.Api.OperatingSystemsApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOperatingSystem**](OperatingSystemsApi.md#getoperatingsystem) | **GET** /v1/operating-systems/{operatingSystemId} | Get operating system by ID |
| [**GetOperatingSystems**](OperatingSystemsApi.md#getoperatingsystems) | **GET** /v1/operating-systems | Get list of operating systems |

<a id="getoperatingsystem"></a>
# **GetOperatingSystem**
> ModelOperatingSystem GetOperatingSystem (int operatingSystemId)

Get operating system by ID

Returns an operating system (supported by the cloud providers) by its ID. The method provides detailed information about each operating system, including its family, type, version, and architecture. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOperatingSystemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OperatingSystemsApi(config);
            var operatingSystemId = 56;  // int | ID of the operating system

            try
            {
                // Get operating system by ID
                ModelOperatingSystem result = apiInstance.GetOperatingSystem(operatingSystemId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperatingSystemsApi.GetOperatingSystem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperatingSystemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get operating system by ID
    ApiResponse<ModelOperatingSystem> response = apiInstance.GetOperatingSystemWithHttpInfo(operatingSystemId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperatingSystemsApi.GetOperatingSystemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **operatingSystemId** | **int** | ID of the operating system |  |

### Return type

[**ModelOperatingSystem**](ModelOperatingSystem.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getoperatingsystems"></a>
# **GetOperatingSystems**
> List&lt;ModelOperatingSystem&gt; GetOperatingSystems (string? type = null, string? architecture = null, string? version = null)

Get list of operating systems

Returns a list of available operating systems of compute instances supported by the cloud providers. The method provides detailed information about each operating system, including its family, type, version, and architecture. Use this list of the operating systems to find an OS when you create any compute instance. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetOperatingSystemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OperatingSystemsApi(config);
            var type = Ubuntu;  // string? | Type of the operating system (optional) 
            var architecture = x86-64;  // string? | Architecture of the operating system (optional) 
            var version = 18.04;  // string? | Version of the operating system (optional) 

            try
            {
                // Get list of operating systems
                List<ModelOperatingSystem> result = apiInstance.GetOperatingSystems(type, architecture, version);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OperatingSystemsApi.GetOperatingSystems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOperatingSystemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of operating systems
    ApiResponse<List<ModelOperatingSystem>> response = apiInstance.GetOperatingSystemsWithHttpInfo(type, architecture, version);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OperatingSystemsApi.GetOperatingSystemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string?** | Type of the operating system | [optional]  |
| **architecture** | **string?** | Architecture of the operating system | [optional]  |
| **version** | **string?** | Version of the operating system | [optional]  |

### Return type

[**List&lt;ModelOperatingSystem&gt;**](ModelOperatingSystem.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

