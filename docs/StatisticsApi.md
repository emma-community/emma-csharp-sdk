# Org.OpenAPITools.Api.StatisticsApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetStatisticalData**](StatisticsApi.md#getstatisticaldata) | **POST** /v1/statistics/retrieve | Extract data from the DWH |

<a id="getstatisticaldata"></a>
# **GetStatisticalData**
> GetStatisticalData200Response GetStatisticalData (GetStatisticalDataRequest? getStatisticalDataRequest = null)

Extract data from the DWH

The method allows extraction of statistical data from emma's DWH. All queries are predefined; users need to select one and specify additional parameters. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetStatisticalDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StatisticsApi(config);
            var getStatisticalDataRequest = new GetStatisticalDataRequest?(); // GetStatisticalDataRequest? |  (optional) 

            try
            {
                // Extract data from the DWH
                GetStatisticalData200Response result = apiInstance.GetStatisticalData(getStatisticalDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatisticalData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticalDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Extract data from the DWH
    ApiResponse<GetStatisticalData200Response> response = apiInstance.GetStatisticalDataWithHttpInfo(getStatisticalDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticalDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getStatisticalDataRequest** | [**GetStatisticalDataRequest?**](GetStatisticalDataRequest?.md) |  | [optional]  |

### Return type

[**GetStatisticalData200Response**](GetStatisticalData200Response.md)

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

