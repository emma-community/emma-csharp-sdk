# Org.OpenAPITools.Api.SubnetworksApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1SubnetworksGet**](SubnetworksApi.md#v1subnetworksget) | **GET** /v1/subnetworks | Get list of subnetworks |
| [**V1SubnetworksPost**](SubnetworksApi.md#v1subnetworkspost) | **POST** /v1/subnetworks | Create subnetwork |
| [**V1SubnetworksSubnetworkIdDelete**](SubnetworksApi.md#v1subnetworkssubnetworkiddelete) | **DELETE** /v1/subnetworks/{subnetworkId} | Delete subnetwork |
| [**V1SubnetworksSubnetworkIdGet**](SubnetworksApi.md#v1subnetworkssubnetworkidget) | **GET** /v1/subnetworks/{subnetworkId} | Get subnetwork by ID |
| [**V1SubnetworksSubnetworkIdPut**](SubnetworksApi.md#v1subnetworkssubnetworkidput) | **PUT** /v1/subnetworks/{subnetworkId} | Update subnetwork |

<a id="v1subnetworksget"></a>
# **V1SubnetworksGet**
> List&lt;Subnetwork&gt; V1SubnetworksGet ()

Get list of subnetworks

Returns a list of subnetworks within the project. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SubnetworksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubnetworksApi(config);

            try
            {
                // Get list of subnetworks
                List<Subnetwork> result = apiInstance.V1SubnetworksGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SubnetworksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of subnetworks
    ApiResponse<List<Subnetwork>> response = apiInstance.V1SubnetworksGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Subnetwork&gt;**](Subnetwork.md)

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
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1subnetworkspost"></a>
# **V1SubnetworksPost**
> Subnetwork V1SubnetworksPost (SubnetworkCreate? subnetworkCreate = null)

Create subnetwork

This method creates a subnetwork. To create a subnetwork, consider the following parameters: 1. Select a data center using the `/v1/data-centers` endpoint. The data center determines the provider and location of the subnetwork. 2. Specify the IP address range (optional) and network size (required). Subnetwork prefix value must be in ranges: 10.0.0.0 - 10.255.255.255, 172.16.0.0 - 172.31.255.255, 192.168.0.0 - 192.168.255.255, network size must be /28-/16 for DigitalOcean and /24-/16 for Gcore. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SubnetworksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubnetworksApi(config);
            var subnetworkCreate = new SubnetworkCreate?(); // SubnetworkCreate? |  (optional) 

            try
            {
                // Create subnetwork
                Subnetwork result = apiInstance.V1SubnetworksPost(subnetworkCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SubnetworksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create subnetwork
    ApiResponse<Subnetwork> response = apiInstance.V1SubnetworksPostWithHttpInfo(subnetworkCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetworkCreate** | [**SubnetworkCreate?**](SubnetworkCreate?.md) |  | [optional]  |

### Return type

[**Subnetwork**](Subnetwork.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1subnetworkssubnetworkiddelete"></a>
# **V1SubnetworksSubnetworkIdDelete**
> Subnetwork V1SubnetworksSubnetworkIdDelete (string subnetworkId)

Delete subnetwork

This method deletes a subnetwork. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SubnetworksSubnetworkIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubnetworksApi(config);
            var subnetworkId = "subnetworkId_example";  // string | Subnetwork ID

            try
            {
                // Delete subnetwork
                Subnetwork result = apiInstance.V1SubnetworksSubnetworkIdDelete(subnetworkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SubnetworksSubnetworkIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete subnetwork
    ApiResponse<Subnetwork> response = apiInstance.V1SubnetworksSubnetworkIdDeleteWithHttpInfo(subnetworkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetworkId** | **string** | Subnetwork ID |  |

### Return type

[**Subnetwork**](Subnetwork.md)

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
| **403** | Forbidden - Access is denied |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1subnetworkssubnetworkidget"></a>
# **V1SubnetworksSubnetworkIdGet**
> Subnetwork V1SubnetworksSubnetworkIdGet (string subnetworkId)

Get subnetwork by ID

Returns a subnetwork by its ID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SubnetworksSubnetworkIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubnetworksApi(config);
            var subnetworkId = "subnetworkId_example";  // string | Subnetwork ID

            try
            {
                // Get subnetwork by ID
                Subnetwork result = apiInstance.V1SubnetworksSubnetworkIdGet(subnetworkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SubnetworksSubnetworkIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subnetwork by ID
    ApiResponse<Subnetwork> response = apiInstance.V1SubnetworksSubnetworkIdGetWithHttpInfo(subnetworkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetworkId** | **string** | Subnetwork ID |  |

### Return type

[**Subnetwork**](Subnetwork.md)

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
| **403** | Forbidden - Access is denied |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1subnetworkssubnetworkidput"></a>
# **V1SubnetworksSubnetworkIdPut**
> Subnetwork V1SubnetworksSubnetworkIdPut (string subnetworkId, SubnetworkEdit? subnetworkEdit = null)

Update subnetwork

This method updates a subnetwork. Only the subnetwork name can be updated. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class V1SubnetworksSubnetworkIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubnetworksApi(config);
            var subnetworkId = "subnetworkId_example";  // string | Subnetwork ID
            var subnetworkEdit = new SubnetworkEdit?(); // SubnetworkEdit? |  (optional) 

            try
            {
                // Update subnetwork
                Subnetwork result = apiInstance.V1SubnetworksSubnetworkIdPut(subnetworkId, subnetworkEdit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1SubnetworksSubnetworkIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update subnetwork
    ApiResponse<Subnetwork> response = apiInstance.V1SubnetworksSubnetworkIdPutWithHttpInfo(subnetworkId, subnetworkEdit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubnetworksApi.V1SubnetworksSubnetworkIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subnetworkId** | **string** | Subnetwork ID |  |
| **subnetworkEdit** | [**SubnetworkEdit?**](SubnetworkEdit?.md) |  | [optional]  |

### Return type

[**Subnetwork**](Subnetwork.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

