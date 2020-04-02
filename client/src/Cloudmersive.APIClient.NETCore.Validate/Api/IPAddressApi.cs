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
    public interface IIPAddressApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Geolocate an IP address
        /// </summary>
        /// <remarks>
        /// Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>GeolocateResponse</returns>
        GeolocateResponse IPAddressPost (string value);

        /// <summary>
        /// Geolocate an IP address
        /// </summary>
        /// <remarks>
        /// Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>ApiResponse of GeolocateResponse</returns>
        ApiResponse<GeolocateResponse> IPAddressPostWithHttpInfo (string value);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Geolocate an IP address
        /// </summary>
        /// <remarks>
        /// Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>Task of GeolocateResponse</returns>
        System.Threading.Tasks.Task<GeolocateResponse> IPAddressPostAsync (string value);

        /// <summary>
        /// Geolocate an IP address
        /// </summary>
        /// <remarks>
        /// Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>Task of ApiResponse (GeolocateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GeolocateResponse>> IPAddressPostAsyncWithHttpInfo (string value);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class IPAddressApi : IIPAddressApi
    {
        private Cloudmersive.APIClient.NETCore.Validate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IPAddressApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NETCore.Validate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public IPAddressApi(Cloudmersive.APIClient.NETCore.Validate.Client.Configuration configuration = null)
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
        /// Geolocate an IP address Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>GeolocateResponse</returns>
        public GeolocateResponse IPAddressPost (string value)
        {
             ApiResponse<GeolocateResponse> localVarResponse = IPAddressPostWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Geolocate an IP address Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>ApiResponse of GeolocateResponse</returns>
        public ApiResponse< GeolocateResponse > IPAddressPostWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling IPAddressApi->IPAddressPost");

            var localVarPath = "./validate/ip/geolocate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/javascript", 
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

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
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
                Exception exception = ExceptionFactory("IPAddressPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeolocateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (GeolocateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocateResponse)));
        }

        /// <summary>
        /// Geolocate an IP address Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>Task of GeolocateResponse</returns>
        public async System.Threading.Tasks.Task<GeolocateResponse> IPAddressPostAsync (string value)
        {
             ApiResponse<GeolocateResponse> localVarResponse = await IPAddressPostAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Geolocate an IP address Identify an IP address Country, State/Provence, City, Zip/Postal Code, etc.  Useful for security and UX applications.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">IP address to geolocate, e.g. \&quot;55.55.55.55\&quot;.  The input is a string so be sure to enclose it in double-quotes.</param>
        /// <returns>Task of ApiResponse (GeolocateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GeolocateResponse>> IPAddressPostAsyncWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling IPAddressApi->IPAddressPost");

            var localVarPath = "./validate/ip/geolocate";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "text/javascript", 
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

            if (value != null && value.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(value); // http body (model) parameter
            }
            else
            {
                localVarPostBody = value; // byte array
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
                Exception exception = ExceptionFactory("IPAddressPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GeolocateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (GeolocateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GeolocateResponse)));
        }

    }
}
