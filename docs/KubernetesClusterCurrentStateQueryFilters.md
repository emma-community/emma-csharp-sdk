# Org.OpenAPITools.Model.KubernetesClusterCurrentStateQueryFilters
List of additional parameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ObjectType** | **string** | Type of kubernetes cluster object | 
**ObjectName** | **string** | Name of the object for which the user requests a list of metrics | 
**BreakdownLevel** | **string** | Kubernetes object breakdown | 
**CurrentStateMetrics** | **List&lt;string&gt;** | List of metrics describing the current state | 
**CustomFilterState** | **string** | State of objects in the custom filter | 
**CustomFilterAvgCpuRule** | **string** | Rule for object filtering by CPU utilization | 
**CustomFilterAvgCpuValue** | **decimal?** | CPU utilization in the custom filter | 
**CustomFilterAvgMemoryRule** | **string** | Rule for object filtering by memory utilization | 
**CustomFilterAvgMemoryValue** | **decimal?** | Memory utilization in the custom filter | 
**CustomFilterAvgStorageRule** | **string** | Rule for object filtering by disk utilization | 
**CustomFilterAvgStorageValue** | **decimal?** | Disk utilization in the custom filter | 
**CustomFilterSubobjects** | **List&lt;string&gt;** | List of subobject to explore | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

