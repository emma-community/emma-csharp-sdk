# Org.OpenAPITools.Api.SSHKeysApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSshKey**](SSHKeysApi.md#getsshkey) | **GET** /v1/ssh-keys/{sshKeyId} | Get SSH key by id |
| [**SshKeyDelete**](SSHKeysApi.md#sshkeydelete) | **DELETE** /v1/ssh-keys/{sshKeyId} | Delete SSH keys |
| [**SshKeyUpdate**](SSHKeysApi.md#sshkeyupdate) | **PUT** /v1/ssh-keys/{sshKeyId} | Update SSH keys |
| [**SshKeys**](SSHKeysApi.md#sshkeys) | **GET** /v1/ssh-keys | Get list of SSH keys |
| [**SshKeysCreateImport**](SSHKeysApi.md#sshkeyscreateimport) | **POST** /v1/ssh-keys | Create or import SSH key |

<a id="getsshkey"></a>
# **GetSshKey**
> SshKey GetSshKey (int sshKeyId)

Get SSH key by id

Returns an SSH key by ID for access to Linux compute instances. You can only retrieve the SSH keys created by the current Service application that you use to send a request. You can't retrieve SSH keys created by other users and applications. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSshKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SSHKeysApi(config);
            var sshKeyId = 56;  // int | SSH key ID

            try
            {
                // Get SSH key by id
                SshKey result = apiInstance.GetSshKey(sshKeyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSHKeysApi.GetSshKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSshKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SSH key by id
    ApiResponse<SshKey> response = apiInstance.GetSshKeyWithHttpInfo(sshKeyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSHKeysApi.GetSshKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sshKeyId** | **int** | SSH key ID |  |

### Return type

[**SshKey**](SshKey.md)

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

<a id="sshkeydelete"></a>
# **SshKeyDelete**
> void SshKeyDelete (int sshKeyId)

Delete SSH keys

This method deletes a SSH key. You can only delete an SSH key created by the current Service application that you use to send a request. You can't delete SSH keys created by other users and applications. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SshKeyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SSHKeysApi(config);
            var sshKeyId = 56;  // int | SSH key ID

            try
            {
                // Delete SSH keys
                apiInstance.SshKeyDelete(sshKeyId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSHKeysApi.SshKeyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshKeyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete SSH keys
    apiInstance.SshKeyDeleteWithHttpInfo(sshKeyId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSHKeysApi.SshKeyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sshKeyId** | **int** | SSH key ID |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful operation |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sshkeyupdate"></a>
# **SshKeyUpdate**
> SshKey SshKeyUpdate (int sshKeyId, SshKeyUpdate? sshKeyUpdate = null)

Update SSH keys

This method updates a name of an existing SSH-key. You can only update an SSH key created by the current Service application that you use to send a request. You can't update SSH keys created by other users and applications. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SshKeyUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SSHKeysApi(config);
            var sshKeyId = 56;  // int | SSH key ID
            var sshKeyUpdate = new SshKeyUpdate?(); // SshKeyUpdate? |  (optional) 

            try
            {
                // Update SSH keys
                SshKey result = apiInstance.SshKeyUpdate(sshKeyId, sshKeyUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSHKeysApi.SshKeyUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshKeyUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update SSH keys
    ApiResponse<SshKey> response = apiInstance.SshKeyUpdateWithHttpInfo(sshKeyId, sshKeyUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSHKeysApi.SshKeyUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sshKeyId** | **int** | SSH key ID |  |
| **sshKeyUpdate** | [**SshKeyUpdate?**](SshKeyUpdate?.md) |  | [optional]  |

### Return type

[**SshKey**](SshKey.md)

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
| **403** | Forbidden |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sshkeys"></a>
# **SshKeys**
> List&lt;SshKey&gt; SshKeys ()

Get list of SSH keys

Returns a list of the SSH keys for access to Linux compute instances. You can use these keys to create compute instances.   The list only contains the SSH keys created by the current Service application that you use to send a request.   You can't retrieve a list of SSH keys created by other users and applications. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SshKeysExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SSHKeysApi(config);

            try
            {
                // Get list of SSH keys
                List<SshKey> result = apiInstance.SshKeys();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSHKeysApi.SshKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of SSH keys
    ApiResponse<List<SshKey>> response = apiInstance.SshKeysWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSHKeysApi.SshKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;SshKey&gt;**](SshKey.md)

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

<a id="sshkeyscreateimport"></a>
# **SshKeysCreateImport**
> SshKeysCreateImport201Response SshKeysCreateImport (SshKeysCreateImportRequest? sshKeysCreateImportRequest = null)

Create or import SSH key

This method creates an SSH key that can be used for Linux compute instance creation. An SSH key can be created in two ways: generated by emma or imported by the user.  If you want to **generate** a key, specify two fields: name and keyType (RSA or ED25519). The key will be generated, and you will receive a private key in the response. The private key will be shown only once, so copy and save it to connect to the Linux compute instances.  If you want to **import** an existing SSH key, specify two fields: name and key. In the key field, insert your public SSH key as a string. It will be imported. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SshKeysCreateImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SSHKeysApi(config);
            var sshKeysCreateImportRequest = new SshKeysCreateImportRequest?(); // SshKeysCreateImportRequest? |  (optional) 

            try
            {
                // Create or import SSH key
                SshKeysCreateImport201Response result = apiInstance.SshKeysCreateImport(sshKeysCreateImportRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SSHKeysApi.SshKeysCreateImport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SshKeysCreateImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or import SSH key
    ApiResponse<SshKeysCreateImport201Response> response = apiInstance.SshKeysCreateImportWithHttpInfo(sshKeysCreateImportRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SSHKeysApi.SshKeysCreateImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sshKeysCreateImportRequest** | [**SshKeysCreateImportRequest?**](SshKeysCreateImportRequest?.md) |  | [optional]  |

### Return type

[**SshKeysCreateImport201Response**](SshKeysCreateImport201Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful operation |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden - Access is denied |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

