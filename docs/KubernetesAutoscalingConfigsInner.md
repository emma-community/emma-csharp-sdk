# Org.OpenAPITools.Model.KubernetesAutoscalingConfigsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupName** | **string** | Name of the autoscaling group | [optional] 
**DataCenterId** | **string** | ID of the data center | [optional] 
**MinimumNodes** | **int** | Minimum number of nodes | [optional] 
**MaximumNodes** | **int** | Maximum number of nodes | [optional] 
**TargetNodes** | **int** | Target number of worker nodes in the autoscaling group | [optional] 
**MinimumVCpus** | **int** | Minimum number of vCPUs | [optional] 
**MaximumVCpus** | **int** | Maximum number of vCPUs | [optional] 
**TargetVCpus** | **int** | Target number of vCPUs in the autoscaling group | [optional] 
**NodeGroupPriceLimit** | **decimal** | Price limit of the autoscaling group | [optional] 
**UseOnDemandInstancesInsteadOfSpots** | **bool** | Use on-demand compute instances instead of spot compute instances | [optional] 
**SpotPercent** | **int** | Percentage of spot instances in the autoscaling group | [optional] 
**SpotMarkup** | **decimal** | Extra markup to the spot instance price | [optional] 
**ConfigurationPriorities** | [**List&lt;KubernetesAutoscalingConfigsInnerConfigurationPrioritiesInner&gt;**](KubernetesAutoscalingConfigsInnerConfigurationPrioritiesInner.md) | Compute instance configurations with priorities | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

