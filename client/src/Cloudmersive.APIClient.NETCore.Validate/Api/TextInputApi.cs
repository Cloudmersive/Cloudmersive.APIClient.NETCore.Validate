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
    public interface ITextInputApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks
        /// </summary>
        /// <remarks>
        /// Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>XssProtectionResult</returns>
        XssProtectionResult TextInputCheckXss (string value);

        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks
        /// </summary>
        /// <remarks>
        /// Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>ApiResponse of XssProtectionResult</returns>
        ApiResponse<XssProtectionResult> TextInputCheckXssWithHttpInfo (string value);
        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
        /// </summary>
        /// <remarks>
        /// Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>XssProtectionResult</returns>
        XssProtectionResult TextInputProtectXss (string value);

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
        /// </summary>
        /// <remarks>
        /// Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>ApiResponse of XssProtectionResult</returns>
        ApiResponse<XssProtectionResult> TextInputProtectXssWithHttpInfo (string value);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks
        /// </summary>
        /// <remarks>
        /// Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of XssProtectionResult</returns>
        System.Threading.Tasks.Task<XssProtectionResult> TextInputCheckXssAsync (string value);

        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks
        /// </summary>
        /// <remarks>
        /// Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of ApiResponse (XssProtectionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<XssProtectionResult>> TextInputCheckXssAsyncWithHttpInfo (string value);
        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
        /// </summary>
        /// <remarks>
        /// Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of XssProtectionResult</returns>
        System.Threading.Tasks.Task<XssProtectionResult> TextInputProtectXssAsync (string value);

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization
        /// </summary>
        /// <remarks>
        /// Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of ApiResponse (XssProtectionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<XssProtectionResult>> TextInputProtectXssAsyncWithHttpInfo (string value);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TextInputApi : ITextInputApi
    {
        private Cloudmersive.APIClient.NETCore.Validate.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TextInputApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NETCore.Validate.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.Validate.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInputApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TextInputApi(Cloudmersive.APIClient.NETCore.Validate.Client.Configuration configuration = null)
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
        /// Check text input for Cross-Site-Scripting (XSS) attacks Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>XssProtectionResult</returns>
        public XssProtectionResult TextInputCheckXss (string value)
        {
             ApiResponse<XssProtectionResult> localVarResponse = TextInputCheckXssWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>ApiResponse of XssProtectionResult</returns>
        public ApiResponse< XssProtectionResult > TextInputCheckXssWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling TextInputApi->TextInputCheckXss");

            var localVarPath = "./validate/text-input/check/xss";
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
                Exception exception = ExceptionFactory("TextInputCheckXss", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<XssProtectionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (XssProtectionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(XssProtectionResult)));
        }

        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of XssProtectionResult</returns>
        public async System.Threading.Tasks.Task<XssProtectionResult> TextInputCheckXssAsync (string value)
        {
             ApiResponse<XssProtectionResult> localVarResponse = await TextInputCheckXssAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Check text input for Cross-Site-Scripting (XSS) attacks Detects XSS (Cross-Site-Scripting) attacks from text input.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of ApiResponse (XssProtectionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XssProtectionResult>> TextInputCheckXssAsyncWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling TextInputApi->TextInputCheckXss");

            var localVarPath = "./validate/text-input/check/xss";
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
                Exception exception = ExceptionFactory("TextInputCheckXss", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<XssProtectionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (XssProtectionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(XssProtectionResult)));
        }

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>XssProtectionResult</returns>
        public XssProtectionResult TextInputProtectXss (string value)
        {
             ApiResponse<XssProtectionResult> localVarResponse = TextInputProtectXssWithHttpInfo(value);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>ApiResponse of XssProtectionResult</returns>
        public ApiResponse< XssProtectionResult > TextInputProtectXssWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling TextInputApi->TextInputProtectXss");

            var localVarPath = "./validate/text-input/protect/xss";
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
                Exception exception = ExceptionFactory("TextInputProtectXss", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<XssProtectionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (XssProtectionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(XssProtectionResult)));
        }

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of XssProtectionResult</returns>
        public async System.Threading.Tasks.Task<XssProtectionResult> TextInputProtectXssAsync (string value)
        {
             ApiResponse<XssProtectionResult> localVarResponse = await TextInputProtectXssAsyncWithHttpInfo(value);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Protect text input from Cross-Site-Scripting (XSS) attacks through normalization Detects and removes XSS (Cross-Site-Scripting) attacks from text input through normalization.  Returns the normalized result, as well as information on whether the original input contained an XSS risk.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.Validate.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="value">User-facing text input.</param>
        /// <returns>Task of ApiResponse (XssProtectionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<XssProtectionResult>> TextInputProtectXssAsyncWithHttpInfo (string value)
        {
            // verify the required parameter 'value' is set
            if (value == null)
                throw new ApiException(400, "Missing required parameter 'value' when calling TextInputApi->TextInputProtectXss");

            var localVarPath = "./validate/text-input/protect/xss";
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
                Exception exception = ExceptionFactory("TextInputProtectXss", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<XssProtectionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (XssProtectionResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(XssProtectionResult)));
        }

    }
}
