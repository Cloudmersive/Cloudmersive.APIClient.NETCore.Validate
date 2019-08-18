# Cloudmersive.APIClient.NETCore.Validate.Api.AddressApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddressParseString**](AddressApi.md#addressparsestring) | **POST** /validate/address/parse | Parse an unstructured input text string into an international, formatted address


<a name="addressparsestring"></a>
# **AddressParseString**
> ParseAddressResponse AddressParseString (ParseAddressRequest input)

Parse an unstructured input text string into an international, formatted address

Uses machine learning and Natural Language Processing (NLP) to handle a wide array of cases, including non-standard and unstructured address strings across a wide array of countries and address formatting norms.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Validate.Api;
using Cloudmersive.APIClient.NETCore.Validate.Client;
using Cloudmersive.APIClient.NETCore.Validate.Model;

namespace Example
{
    public class AddressParseStringExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new ParseAddressRequest(); // ParseAddressRequest | Input parse request

            try
            {
                // Parse an unstructured input text string into an international, formatted address
                ParseAddressResponse result = apiInstance.AddressParseString(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressParseString: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**ParseAddressRequest**](ParseAddressRequest.md)| Input parse request | 

### Return type

[**ParseAddressResponse**](ParseAddressResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
