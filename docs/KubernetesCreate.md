# Org.OpenAPITools.Model.KubernetesCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Kubernetes cluster name | 
**DeploymentLocation** | **string** | Deployment region of the Kubernetes cluster. Currently, only Europe (eu) is available. | 
**WorkerNodes** | [**List&lt;KubernetesCreateWorkerNodesInner&gt;**](KubernetesCreateWorkerNodesInner.md) | List of the worker nodes | 
**AutoscalingConfigs** | [**List&lt;KubernetesCreateAutoscalingConfigsInner&gt;**](KubernetesCreateAutoscalingConfigsInner.md) | Configurations of the autoscaling group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

