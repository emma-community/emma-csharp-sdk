# Org.OpenAPITools.Api.KubernetesClustersApi

All URIs are relative to *https://api.emma.ms/external*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateKubernetesCluster**](KubernetesClustersApi.md#createkubernetescluster) | **POST** /v1/kubernetes | Create Kubernetes cluster |
| [**DeleteKubernetesCluster**](KubernetesClustersApi.md#deletekubernetescluster) | **DELETE** /v1/kubernetes/{kubernetesId} | Delete Kubernetes cluster |
| [**EditKubernetesCluster**](KubernetesClustersApi.md#editkubernetescluster) | **PUT** /v1/kubernetes/{kubernetesId} | Edit Kubernetes cluster |
| [**GetKubernetesCluster**](KubernetesClustersApi.md#getkubernetescluster) | **GET** /v1/kubernetes/{kubernetesId} | Get Kubernetes cluster by id |
| [**GetKubernetesClusters**](KubernetesClustersApi.md#getkubernetesclusters) | **GET** /v1/kubernetes | Get list of Kubernetes clusters |

<a id="createkubernetescluster"></a>
# **CreateKubernetesCluster**
> List&lt;Kubernetes&gt; CreateKubernetesCluster (KubernetesCreate? kubernetesCreate = null)

Create Kubernetes cluster

Creates a Managed Kubernetes cluster. Kubernetes Service provides you with the ability to deploy and manage Kubernetes clusters without worrying about the setup and maintenance of master nodes. emma takes care of managing the Kubernetes control planes, allowing you to focus on deploying and managing your applications. You don't need to create master nodes.   We offer a reliable and highly available infrastructure for your cluster, which is hosted across three cloud providers: **Amazon Web Services (AWS), Microsoft Azure,** and **Google Cloud Platform (GCP)**. The service ensures independence from a single cloud provider. You can deploy your cluster across the networks of three providers.  Currently, you can only place clusters in **European regions** of cloud providers.  When creating worker nodes, you need to select the appropriate hardware configurations. The configuration depends on the provider and the data center. Use the `/v1/kubernetes-configs` endpoint to find available configurations for worker nodes.  Cluster currently supports up to 5 autoscaling groups and a total of 16 worker nodes. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateKubernetesClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new KubernetesClustersApi(config);
            var kubernetesCreate = new KubernetesCreate?(); // KubernetesCreate? |  (optional) 

            try
            {
                // Create Kubernetes cluster
                List<Kubernetes> result = apiInstance.CreateKubernetesCluster(kubernetesCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KubernetesClustersApi.CreateKubernetesCluster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateKubernetesClusterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Kubernetes cluster
    ApiResponse<List<Kubernetes>> response = apiInstance.CreateKubernetesClusterWithHttpInfo(kubernetesCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KubernetesClustersApi.CreateKubernetesClusterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **kubernetesCreate** | [**KubernetesCreate?**](KubernetesCreate?.md) |  | [optional]  |

### Return type

[**List&lt;Kubernetes&gt;**](Kubernetes.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletekubernetescluster"></a>
# **DeleteKubernetesCluster**
> Kubernetes DeleteKubernetesCluster (int kubernetesId)

Delete Kubernetes cluster

This method deletes an existing managed Kubernetes cluster. Deleting a cluster will result in the termination of all the worker nodes and the master node that was part of the cluster. All the data stored on the nodes, including the container images, logs, and application data, will also be lost. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteKubernetesClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new KubernetesClustersApi(config);
            var kubernetesId = 56;  // int | ID of the Kubernetes cluster

            try
            {
                // Delete Kubernetes cluster
                Kubernetes result = apiInstance.DeleteKubernetesCluster(kubernetesId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KubernetesClustersApi.DeleteKubernetesCluster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteKubernetesClusterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Kubernetes cluster
    ApiResponse<Kubernetes> response = apiInstance.DeleteKubernetesClusterWithHttpInfo(kubernetesId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KubernetesClustersApi.DeleteKubernetesClusterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **kubernetesId** | **int** | ID of the Kubernetes cluster |  |

### Return type

[**Kubernetes**](Kubernetes.md)

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
| **403** | Forbidden |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="editkubernetescluster"></a>
# **EditKubernetesCluster**
> Kubernetes EditKubernetesCluster (int kubernetesId, KubernetesUpdate? kubernetesUpdate = null)

Edit Kubernetes cluster

The method for editing a Managed Kubernetes cluster enables you to delete and add new worker nodes and autoscaling groups, as well as change the settings of existing autoscaling groups. You can only edit a cluster when it is in \"ACTIVE\" status. To select hardware configurations for worker nodes, use the /v1/kubernetes-configs endpoint.  When editing a Kubernetes cluster, you can only add or delete worker nodes, but you cannot change the name or configuration of existing worker nodes. If you want to keep a node when editing a cluster, simply specify its ID in the 'workerNodes' object. All other fields in 'workerNodes' are ignored for existing nodes and are not required. If you want to delete a node, remove its ID.  When you create a new node, all fields in the 'workerNodes' object (except ID) are required. Do not add the ID field for a new node.  Please note that the spotMarkup field is ignored for the GCP provider.  When you delete an autoscaling group with existing worker nodes, the worker nodes are also deleted.  During the changes, the cluster status will change to \"ENV_DEVELOPMENT.\" Nodes undergoing changes will be displayed with a \"BUSY\" status. When the changes are successfully applied, the cluster will transition back to the \"ACTIVE\" status, and the nodes will be in the \"ON\" status. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EditKubernetesClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new KubernetesClustersApi(config);
            var kubernetesId = 56;  // int | ID of the Kubernetes cluster
            var kubernetesUpdate = new KubernetesUpdate?(); // KubernetesUpdate? |  (optional) 

            try
            {
                // Edit Kubernetes cluster
                Kubernetes result = apiInstance.EditKubernetesCluster(kubernetesId, kubernetesUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KubernetesClustersApi.EditKubernetesCluster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EditKubernetesClusterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit Kubernetes cluster
    ApiResponse<Kubernetes> response = apiInstance.EditKubernetesClusterWithHttpInfo(kubernetesId, kubernetesUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KubernetesClustersApi.EditKubernetesClusterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **kubernetesId** | **int** | ID of the Kubernetes cluster |  |
| **kubernetesUpdate** | [**KubernetesUpdate?**](KubernetesUpdate?.md) |  | [optional]  |

### Return type

[**Kubernetes**](Kubernetes.md)

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

<a id="getkubernetescluster"></a>
# **GetKubernetesCluster**
> Kubernetes GetKubernetesCluster (int kubernetesId)

Get Kubernetes cluster by id

Returns a Managed Kubernetes cluster by cluster ID. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetKubernetesClusterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new KubernetesClustersApi(config);
            var kubernetesId = 56;  // int | ID of the Kubernetes cluster

            try
            {
                // Get Kubernetes cluster by id
                Kubernetes result = apiInstance.GetKubernetesCluster(kubernetesId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KubernetesClustersApi.GetKubernetesCluster: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetKubernetesClusterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Kubernetes cluster by id
    ApiResponse<Kubernetes> response = apiInstance.GetKubernetesClusterWithHttpInfo(kubernetesId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KubernetesClustersApi.GetKubernetesClusterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **kubernetesId** | **int** | ID of the Kubernetes cluster |  |

### Return type

[**Kubernetes**](Kubernetes.md)

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
| **403** | Forbidden |  -  |
| **404** | Not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getkubernetesclusters"></a>
# **GetKubernetesClusters**
> List&lt;Kubernetes&gt; GetKubernetesClusters ()

Get list of Kubernetes clusters

Returns a list of created Kubernetes clusters. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetKubernetesClustersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.emma.ms/external";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new KubernetesClustersApi(config);

            try
            {
                // Get list of Kubernetes clusters
                List<Kubernetes> result = apiInstance.GetKubernetesClusters();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling KubernetesClustersApi.GetKubernetesClusters: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetKubernetesClustersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of Kubernetes clusters
    ApiResponse<List<Kubernetes>> response = apiInstance.GetKubernetesClustersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling KubernetesClustersApi.GetKubernetesClustersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Kubernetes&gt;**](Kubernetes.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

