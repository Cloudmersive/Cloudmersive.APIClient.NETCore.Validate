# Cloudmersive.APIClient.NETCore.Validate - the C# library for the validateapi

The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.

This C# SDK is for the [Cloudmersive Validate API](https://www.cloudmersive.com/validate-api):

- API version: v1
- SDK version: 2.0.9
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.Validate.Api;
using Cloudmersive.APIClient.NETCore.Validate.Client;
using Cloudmersive.APIClient.NETCore.Validate.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.Validate.Api;
using Cloudmersive.APIClient.NETCore.Validate.Client;
using Cloudmersive.APIClient.NETCore.Validate.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new AddressApi();
            var input = new ValidateCountryRequest(); // ValidateCountryRequest | Input request

            try
            {
                // Check if a country is a member of the European Union (EU)
                ValidateCountryResponse result = apiInstance.AddressCheckEUMembership(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressApi.AddressCheckEUMembership: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressApi* | [**AddressCheckEUMembership**](docs/AddressApi.md#addresscheckeumembership) | **POST** /validate/address/country/check-eu-membership | Check if a country is a member of the European Union (EU)
*AddressApi* | [**AddressCountry**](docs/AddressApi.md#addresscountry) | **POST** /validate/address/country | Validate and normalize country information, return ISO 3166-1 country codes and country name
*AddressApi* | [**AddressCountryList**](docs/AddressApi.md#addresscountrylist) | **POST** /validate/address/country/list | Get a list of ISO 3166-1 countries
*AddressApi* | [**AddressGetCountryCurrency**](docs/AddressApi.md#addressgetcountrycurrency) | **POST** /validate/address/country/get-currency | Get the currency of the input country
*AddressApi* | [**AddressGetCountryRegion**](docs/AddressApi.md#addressgetcountryregion) | **POST** /validate/address/country/get-region | Get the region, subregion and continent of the country
*AddressApi* | [**AddressGetTimezone**](docs/AddressApi.md#addressgettimezone) | **POST** /validate/address/country/get-timezones | Gets IANA/Olsen time zones for a country
*AddressApi* | [**AddressParseString**](docs/AddressApi.md#addressparsestring) | **POST** /validate/address/parse | Parse an unstructured input text string into an international, formatted address
*AddressApi* | [**AddressValidateAddress**](docs/AddressApi.md#addressvalidateaddress) | **POST** /validate/address/street-address | Validate a street address
*AddressApi* | [**AddressValidateCity**](docs/AddressApi.md#addressvalidatecity) | **POST** /validate/address/city | Validate a City and State/Province combination, get location information about it
*AddressApi* | [**AddressValidatePostalCode**](docs/AddressApi.md#addressvalidatepostalcode) | **POST** /validate/address/postal-code | Validate a postal code, get location information about it
*AddressApi* | [**AddressValidateState**](docs/AddressApi.md#addressvalidatestate) | **POST** /validate/address/state | Validate a state or province, name or abbreviation, get location information about it
*DomainApi* | [**DomainCheck**](docs/DomainApi.md#domaincheck) | **POST** /validate/domain/check | Validate a domain name
*DomainApi* | [**DomainPost**](docs/DomainApi.md#domainpost) | **POST** /validate/domain/whois | Get WHOIS information for a domain
*DomainApi* | [**DomainQualityScore**](docs/DomainApi.md#domainqualityscore) | **POST** /validate/domain/quality-score | Validate a domain name's quality score
*DomainApi* | [**DomainUrlFull**](docs/DomainApi.md#domainurlfull) | **POST** /validate/domain/url/full | Validate a URL fully
*DomainApi* | [**DomainUrlSyntaxOnly**](docs/DomainApi.md#domainurlsyntaxonly) | **POST** /validate/domain/url/syntax-only | Validate a URL syntactically
*EmailApi* | [**EmailAddressGetServers**](docs/EmailApi.md#emailaddressgetservers) | **POST** /validate/email/address/servers | Partially check whether an email address is valid
*EmailApi* | [**EmailFullValidation**](docs/EmailApi.md#emailfullvalidation) | **POST** /validate/email/address/full | Fully validate an email address
*EmailApi* | [**EmailPost**](docs/EmailApi.md#emailpost) | **POST** /validate/email/address/syntaxOnly | Validate email adddress for syntactic correctness only
*IPAddressApi* | [**IPAddressIsThreat**](docs/IPAddressApi.md#ipaddressisthreat) | **POST** /validate/ip/is-threat | Check if IP address is a known threat
*IPAddressApi* | [**IPAddressIsTorNode**](docs/IPAddressApi.md#ipaddressistornode) | **POST** /validate/ip/is-tor-node | Check if IP address is a Tor node server
*IPAddressApi* | [**IPAddressPost**](docs/IPAddressApi.md#ipaddresspost) | **POST** /validate/ip/geolocate | Geolocate an IP address
*LeadEnrichmentApi* | [**LeadEnrichmentEnrichLead**](docs/LeadEnrichmentApi.md#leadenrichmentenrichlead) | **POST** /validate/lead-enrichment/lead/enrich | Enrich an input lead with additional fields of data
*NameApi* | [**NameGetGender**](docs/NameApi.md#namegetgender) | **POST** /validate/name/get-gender | Get the gender of a first name
*NameApi* | [**NameIdentifier**](docs/NameApi.md#nameidentifier) | **POST** /validate/name/identifier | Validate a code identifier
*NameApi* | [**NameValidateFirstName**](docs/NameApi.md#namevalidatefirstname) | **POST** /validate/name/first | Validate a first name
*NameApi* | [**NameValidateFullName**](docs/NameApi.md#namevalidatefullname) | **POST** /validate/name/full-name | Parse and validate a full name
*NameApi* | [**NameValidateLastName**](docs/NameApi.md#namevalidatelastname) | **POST** /validate/name/last | Validate a last name
*PhoneNumberApi* | [**PhoneNumberSyntaxOnly**](docs/PhoneNumberApi.md#phonenumbersyntaxonly) | **POST** /validate/phonenumber/basic | Validate phone number (basic)
*UserAgentApi* | [**UserAgentParse**](docs/UserAgentApi.md#useragentparse) | **POST** /validate/useragent/parse | Parse an HTTP User-Agent string, identify robots
*VatApi* | [**VatVatLookup**](docs/VatApi.md#vatvatlookup) | **POST** /validate/vat/lookup | Validate a VAT number


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressGetServersResponse](docs/AddressGetServersResponse.md)
 - [Model.AddressVerifySyntaxOnlyResponse](docs/AddressVerifySyntaxOnlyResponse.md)
 - [Model.CheckResponse](docs/CheckResponse.md)
 - [Model.CountryDetails](docs/CountryDetails.md)
 - [Model.CountryListResult](docs/CountryListResult.md)
 - [Model.DomainQualityResponse](docs/DomainQualityResponse.md)
 - [Model.FirstNameValidationRequest](docs/FirstNameValidationRequest.md)
 - [Model.FirstNameValidationResponse](docs/FirstNameValidationResponse.md)
 - [Model.FullEmailValidationResponse](docs/FullEmailValidationResponse.md)
 - [Model.FullNameValidationRequest](docs/FullNameValidationRequest.md)
 - [Model.FullNameValidationResponse](docs/FullNameValidationResponse.md)
 - [Model.GeolocateResponse](docs/GeolocateResponse.md)
 - [Model.GetGenderRequest](docs/GetGenderRequest.md)
 - [Model.GetGenderResponse](docs/GetGenderResponse.md)
 - [Model.GetTimezonesRequest](docs/GetTimezonesRequest.md)
 - [Model.GetTimezonesResponse](docs/GetTimezonesResponse.md)
 - [Model.IPThreatResponse](docs/IPThreatResponse.md)
 - [Model.LastNameValidationRequest](docs/LastNameValidationRequest.md)
 - [Model.LastNameValidationResponse](docs/LastNameValidationResponse.md)
 - [Model.LeadEnrichmentRequest](docs/LeadEnrichmentRequest.md)
 - [Model.LeadEnrichmentResponse](docs/LeadEnrichmentResponse.md)
 - [Model.ParseAddressRequest](docs/ParseAddressRequest.md)
 - [Model.ParseAddressResponse](docs/ParseAddressResponse.md)
 - [Model.PhoneNumberValidateRequest](docs/PhoneNumberValidateRequest.md)
 - [Model.PhoneNumberValidationResponse](docs/PhoneNumberValidationResponse.md)
 - [Model.Timezone](docs/Timezone.md)
 - [Model.TorNodeResponse](docs/TorNodeResponse.md)
 - [Model.UserAgentValidateRequest](docs/UserAgentValidateRequest.md)
 - [Model.UserAgentValidateResponse](docs/UserAgentValidateResponse.md)
 - [Model.ValidateAddressRequest](docs/ValidateAddressRequest.md)
 - [Model.ValidateAddressResponse](docs/ValidateAddressResponse.md)
 - [Model.ValidateCityRequest](docs/ValidateCityRequest.md)
 - [Model.ValidateCityResponse](docs/ValidateCityResponse.md)
 - [Model.ValidateCountryRequest](docs/ValidateCountryRequest.md)
 - [Model.ValidateCountryResponse](docs/ValidateCountryResponse.md)
 - [Model.ValidateIdentifierRequest](docs/ValidateIdentifierRequest.md)
 - [Model.ValidateIdentifierResponse](docs/ValidateIdentifierResponse.md)
 - [Model.ValidatePostalCodeRequest](docs/ValidatePostalCodeRequest.md)
 - [Model.ValidatePostalCodeResponse](docs/ValidatePostalCodeResponse.md)
 - [Model.ValidateStateRequest](docs/ValidateStateRequest.md)
 - [Model.ValidateStateResponse](docs/ValidateStateResponse.md)
 - [Model.ValidateUrlRequestFull](docs/ValidateUrlRequestFull.md)
 - [Model.ValidateUrlRequestSyntaxOnly](docs/ValidateUrlRequestSyntaxOnly.md)
 - [Model.ValidateUrlResponseFull](docs/ValidateUrlResponseFull.md)
 - [Model.ValidateUrlResponseSyntaxOnly](docs/ValidateUrlResponseSyntaxOnly.md)
 - [Model.VatLookupRequest](docs/VatLookupRequest.md)
 - [Model.VatLookupResponse](docs/VatLookupResponse.md)
 - [Model.WhoisResponse](docs/WhoisResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

