# Okta.Sdk.Model.APIServiceIntegrationInstance

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigGuideUrl** | **string** | The URL to the API service integration configuration guide | [optional] [readonly] 
**CreatedAt** | **string** | Timestamp when the API Service Integration instance was created | [optional] [readonly] 
**CreatedBy** | **string** | The user ID of the API Service Integration instance creator | [optional] [readonly] 
**GrantedScopes** | **List&lt;string&gt;** | The list of Okta management scopes granted to the API Service Integration instance. See [Okta management OAuth 2.0 scopes](/oauth2/#okta-admin-management). | [optional] 
**Id** | **string** | The ID of the API Service Integration instance | [optional] [readonly] 
**Name** | **string** | The name of the API service integration that corresponds with the &#x60;type&#x60; property. This is the full name of the API service integration listed in the Okta Integration Network (OIN) catalog. | [optional] [readonly] 
**Type** | **string** | The type of the API service integration. This string is an underscore-concatenated, lowercased API service integration name. For example, &#x60;my_api_log_integration&#x60;. | [optional] 
**Links** | [**APIServiceIntegrationLinks**](APIServiceIntegrationLinks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

