# Org.OpenAPITools.Model.SecurityGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | Security group id | [optional] 
**Name** | **string** | Security group name | [optional] 
**CreatedById** | **int** | ID of the user who created the security group | [optional] 
**CreatedByName** | **string** | Name of the user who created the security group | [optional] 
**ModifiedById** | **int** | ID of the user who last edited the security group | [optional] 
**ModifiedByName** | **string** | Name of the user who last edited the security group | [optional] 
**CreatedAt** | **string** | Date and time of the security group&#39;s creation | [optional] 
**ModifiedAt** | **string** | Date and time of the security group&#39;s last update | [optional] 
**SynchronizationStatus** | **string** | Synchronization status of the security group. When you make changes in the rules the changes are propagated to the respective provider’s security groups. While this is happening the security groups have the status Synchronizing. After it is done the status changes to Synchronized. When another VM is added to the security group it will not be synchronized at first with the other VMs, therefore the status will be Desynchronized. | [optional] 
**RecomposingStatus** | **string** | Recomposing status of the security group. When a new Virtual machine is added to the Security group it starts a synchronization process. During this process the Security group will have a Recomposing status. | [optional] 
**LastModificationErrorDescription** | **string** | Text of the error when the Security group was last edited | [optional] 
**Rules** | [**List&lt;SecurityGroupRule&gt;**](SecurityGroupRule.md) | List of the inbound and outbound rules in the Security group | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

