# Org.OpenAPITools.Model.Kubernetes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the Kubernetes cluster | [optional] 
**CreatedAt** | **string** | Date and time of the Kubernetes cluster creation | [optional] 
**CreatedByName** | **string** | Name of the user who created the Kubernetes cluster | [optional] 
**CreatedById** | **int** | ID of the user who created the Kubernetes cluster | [optional] 
**ModifiedAt** | **string** | Date and time when the Kubernetes cluster was last edited | [optional] 
**ModifiedByName** | **string** | Name of the user who last edited the Kubernetes cluster | [optional] 
**ModifiedById** | **int** | ID of the user who last edited the Kubernetes cluster | [optional] 
**Name** | **string** | Name of the Kubernetes cluster | [optional] 
**VarVersion** | **string** | Version of the Kubernetes cluster | [optional] 
**DeploymentLocation** | **string** | Deployment region of the Kubernetes cluster. Currently, only Europe (eu) is available. | [optional] 
**Status** | **string** | Status of the Kubernetes cluster | [optional] 
**Cost** | [**KubernetesCost**](KubernetesCost.md) |  | [optional] 
**ControlPlaneStatus** | **string** | Control Plane Status. The Control Plane status provides information about the health and functionality of various components that are part of the Control Plane. | [optional] 
**DomainName** | **string** | Domain attached to the Kubernetes cluster | [optional] 
**NodeGroups** | [**List&lt;KubernetesNodeGroupsInner&gt;**](KubernetesNodeGroupsInner.md) | List of the worker node groups | [optional] 
**AutoscalingConfigs** | [**List&lt;KubernetesAutoscalingConfigsInner&gt;**](KubernetesAutoscalingConfigsInner.md) | Configurations of the autoscaling group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

