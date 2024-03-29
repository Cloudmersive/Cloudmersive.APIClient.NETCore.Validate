/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Cloudmersive.APIClient.NETCore.Validate.Client;
using Cloudmersive.APIClient.NETCore.Validate.Model;

namespace Cloudmersive.APIClient.NETCore.Validate.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILeadEnrichmentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Enrich an input lead with additional fields of data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>LeadEnrichmentResponse</returns>
        LeadEnrichmentResponse LeadEnrichmentEnrichLead (LeadEnrichmentRequest request);

        /// <summary>
        /// Enrich an input lead with additional fields of data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>ApiResponse of LeadEnrichmentResponse</returns>
        ApiResponse<LeadEnrichmentResponse> LeadEnrichmentEnrichLeadWithHttpInfo (LeadEnrichmentRequest request);
        /// <summary>
        /// Get company information from email address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>LeadEnrichmentResponse</returns>
        LeadEnrichmentResponse LeadEnrichmentGetCompanyInformation (EmailLead request);

        /// <summary>
        /// Get company information from email address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>ApiResponse of LeadEnrichmentResponse</returns>
        ApiResponse<LeadEnrichmentResponse> LeadEnrichmentGetCompanyInformationWithHttpInfo (EmailLead request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Enrich an input lead with additional fields of data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>Task of LeadEnrichmentResponse</returns>
        System.Threading.Tasks.Task<LeadEnrichmentResponse> LeadEnrichmentEnrichLeadAsync (LeadEnrichmentRequest request);

        /// <summary>
        /// Enrich an input lead with additional fields of data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>Task of ApiResponse (LeadEnrichmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LeadEnrichmentResponse>> LeadEnrichmentEnrichLeadAsyncWithHttpInfo (LeadEnrichmentRequest request);
        /// <summary>
        /// Get company information from email address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>Task of LeadEnrichmentResponse</returns>
        System.Threading.Tasks.Task<LeadEnrichmentResponse> LeadEnrichmentGetCompanyInformationAsync (EmailLead request);

        /// <summary>
        /// Get company information from email address
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>Task of ApiResponse (LeadEnrichmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LeadEnrichmentResponse>> LeadEnrichmentGetCompanyInformationAsyncWithHttpInfo (EmailLead request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LeadEnrichmentApi : ILeadEnrichmentApi
    {
        private Cloudmersive.APIClient.NETCore.Validate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEnrichmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LeadEnrichmentApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NETCore.Validate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeadEnrichmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LeadEnrichmentApi(Cloudmersive.APIClient.NETCore.Validate.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NETCore.Validate.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NETCore.Validate.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.Validate.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Enrich an input lead with additional fields of data 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>LeadEnrichmentResponse</returns>
        public LeadEnrichmentResponse LeadEnrichmentEnrichLead (LeadEnrichmentRequest request)
        {
             ApiResponse<LeadEnrichmentResponse> localVarResponse = LeadEnrichmentEnrichLeadWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enrich an input lead with additional fields of data 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>ApiResponse of LeadEnrichmentResponse</returns>
        public ApiResponse< LeadEnrichmentResponse > LeadEnrichmentEnrichLeadWithHttpInfo (LeadEnrichmentRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling LeadEnrichmentApi->LeadEnrichmentEnrichLead");

            var localVarPath = "./validate/lead-enrichment/lead/enrich";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LeadEnrichmentEnrichLead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LeadEnrichmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LeadEnrichmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LeadEnrichmentResponse)));
        }

        /// <summary>
        /// Enrich an input lead with additional fields of data 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>Task of LeadEnrichmentResponse</returns>
        public async System.Threading.Tasks.Task<LeadEnrichmentResponse> LeadEnrichmentEnrichLeadAsync (LeadEnrichmentRequest request)
        {
             ApiResponse<LeadEnrichmentResponse> localVarResponse = await LeadEnrichmentEnrichLeadAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enrich an input lead with additional fields of data 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input lead with known fields set, and unknown fields left blank (null)</param>
        /// <returns>Task of ApiResponse (LeadEnrichmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LeadEnrichmentResponse>> LeadEnrichmentEnrichLeadAsyncWithHttpInfo (LeadEnrichmentRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling LeadEnrichmentApi->LeadEnrichmentEnrichLead");

            var localVarPath = "./validate/lead-enrichment/lead/enrich";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LeadEnrichmentEnrichLead", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LeadEnrichmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LeadEnrichmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LeadEnrichmentResponse)));
        }

        /// <summary>
        /// Get company information from email address 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>LeadEnrichmentResponse</returns>
        public LeadEnrichmentResponse LeadEnrichmentGetCompanyInformation (EmailLead request)
        {
             ApiResponse<LeadEnrichmentResponse> localVarResponse = LeadEnrichmentGetCompanyInformationWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get company information from email address 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>ApiResponse of LeadEnrichmentResponse</returns>
        public ApiResponse< LeadEnrichmentResponse > LeadEnrichmentGetCompanyInformationWithHttpInfo (EmailLead request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling LeadEnrichmentApi->LeadEnrichmentGetCompanyInformation");

            var localVarPath = "./validate/lead-enrichment/lead/email/company-information";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LeadEnrichmentGetCompanyInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LeadEnrichmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LeadEnrichmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LeadEnrichmentResponse)));
        }

        /// <summary>
        /// Get company information from email address 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>Task of LeadEnrichmentResponse</returns>
        public async System.Threading.Tasks.Task<LeadEnrichmentResponse> LeadEnrichmentGetCompanyInformationAsync (EmailLead request)
        {
             ApiResponse<LeadEnrichmentResponse> localVarResponse = await LeadEnrichmentGetCompanyInformationAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get company information from email address 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Input email address lead</param>
        /// <returns>Task of ApiResponse (LeadEnrichmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LeadEnrichmentResponse>> LeadEnrichmentGetCompanyInformationAsyncWithHttpInfo (EmailLead request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling LeadEnrichmentApi->LeadEnrichmentGetCompanyInformation");

            var localVarPath = "./validate/lead-enrichment/lead/email/company-information";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LeadEnrichmentGetCompanyInformation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LeadEnrichmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (LeadEnrichmentResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(LeadEnrichmentResponse)));
        }

    }
}
