# Org.OpenAPITools.Model.SecurityGroupRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the security group rule | [optional] 
**Policy** | **string** | Rule policy (all rules are allowing) | [optional] 
**Direction** | **string** | Direction of the network traffic: inbound or outbound.  | [optional] 
**Protocol** | **string** | Network protocol of the rule | [optional] 
**Ports** | **string** | Allowed port or port range | [optional] 
**IpRange** | **string** | Allowed IP or IP range | [optional] 
**IsMutable** | **bool** | Indicates if the rule can be edited. Some security group rules are added by default, cannot be changed, and are marked as immutable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

