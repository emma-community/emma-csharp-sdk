# Org.OpenAPITools.Model.KubernetesNodeGroupsInnerNodesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the worker node | [optional] 
**CreatedAt** | **string** | Date and time when the worker node was created | [optional] 
**Name** | **string** | Name of the worker node | [optional] 
**Status** | **string** | Status of the worker node | [optional] 
**Provider** | [**KubernetesNodeGroupsInnerNodesInnerProvider**](KubernetesNodeGroupsInnerNodesInnerProvider.md) |  | [optional] 
**Location** | [**KubernetesNodeGroupsInnerNodesInnerLocation**](KubernetesNodeGroupsInnerNodesInnerLocation.md) |  | [optional] 
**DataCenter** | [**KubernetesNodeGroupsInnerNodesInnerDataCenter**](KubernetesNodeGroupsInnerNodesInnerDataCenter.md) |  | [optional] 
**Os** | [**KubernetesNodeGroupsInnerNodesInnerOs**](KubernetesNodeGroupsInnerNodesInnerOs.md) |  | [optional] 
**VCpu** | **int** | Number of virtual Central Processing Units (vCPUs) | [optional] 
**VCpuType** | **string** | Type of the virtual Central Processing Unit | [optional] 
**CloudNetworkType** | **string** | Type of the cloud network (multi-cloud, isolated, or default) | [optional] 
**RamGb** | **int** | Capacity of the RAM in gigabytes | [optional] 
**Disks** | [**List&lt;KubernetesNodeGroupsInnerNodesInnerDisksInner&gt;**](KubernetesNodeGroupsInnerNodesInnerDisksInner.md) | Volumes attached | [optional] 
**Networks** | [**List&lt;KubernetesNodeGroupsInnerNodesInnerNetworksInner&gt;**](KubernetesNodeGroupsInnerNodesInnerNetworksInner.md) | Public and private networks | [optional] 
**SecurityGroup** | [**KubernetesNodeGroupsInnerNodesInnerSecurityGroup**](KubernetesNodeGroupsInnerNodesInnerSecurityGroup.md) |  | [optional] 
**Cost** | [**KubernetesNodeGroupsInnerNodesInnerCost**](KubernetesNodeGroupsInnerNodesInnerCost.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

