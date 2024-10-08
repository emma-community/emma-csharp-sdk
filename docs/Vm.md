# Org.OpenAPITools.Model.Vm

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | ID of the virtual machine | [optional] 
**CreatedAt** | **string** | Date and time when the virtual machine was created | [optional] 
**CreatedByName** | **string** | Name of the user who created the virtual machine | [optional] 
**CreatedById** | **int** | ID of the user who created the virtual machine | [optional] 
**ModifiedAt** | **string** | Date and time when the virtual machine was last edited | [optional] 
**ModifiedByName** | **string** | Name of the user who last edited the virtual machine | [optional] 
**ModifiedById** | **int** | ID of the user who last edited the virtual machine | [optional] 
**Name** | **string** | Name of the virtual machine | [optional] 
**ProjectId** | **int** | Project ID | [optional] 
**Status** | **string** | Status of the virtual machine | [optional] 
**Provider** | [**VmProvider**](VmProvider.md) |  | [optional] 
**Location** | [**VmLocation**](VmLocation.md) |  | [optional] 
**DataCenter** | [**VmDataCenter**](VmDataCenter.md) |  | [optional] 
**Os** | [**VmOs**](VmOs.md) |  | [optional] 
**VCpu** | **int** | Number of virtual Central Processing Units (vCPUs) | [optional] 
**VCpuType** | **string** | Type of virtual Central Processing Units (vCPUs) | [optional] 
**CloudNetworkType** | **string** | Cloud network type | [optional] 
**RamGb** | **int** | Capacity of the RAM in gigabytes | [optional] 
**Disks** | [**List&lt;KubernetesNodeGroupsInnerNodesInnerDisksInner&gt;**](KubernetesNodeGroupsInnerNodesInnerDisksInner.md) | List of volumes | [optional] 
**Networks** | [**List&lt;KubernetesNodeGroupsInnerNodesInnerNetworksInner&gt;**](KubernetesNodeGroupsInnerNodesInnerNetworksInner.md) |  | [optional] 
**SecurityGroup** | [**VmSecurityGroup**](VmSecurityGroup.md) |  | [optional] 
**Subnetwork** | [**VmSubnetwork**](VmSubnetwork.md) |  | [optional] 
**SshKeyId** | **int** | SSH key ID | [optional] 
**UserName** | **string** | User name | [optional] 
**Cost** | [**VmCost**](VmCost.md) |  | [optional] 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

