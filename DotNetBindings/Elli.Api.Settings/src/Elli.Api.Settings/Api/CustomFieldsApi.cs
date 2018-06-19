/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Settings
 *
 * Represents settings operations on Company, Loan, Contact etc.
 *
 * OpenAPI spec version: 1.2.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elli.Api.Settings.Client;
using Elli.Api.Settings.Model;

namespace Elli.Api.Settings.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICustomFieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get specific loan custom field
        /// </summary>
        /// <remarks>
        /// Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>CustomFieldContract</returns>
        CustomFieldContract GetLoanCustomField (string customFieldId);

        /// <summary>
        /// Get specific loan custom field
        /// </summary>
        /// <remarks>
        /// Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>ApiResponse of CustomFieldContract</returns>
        ApiResponse<CustomFieldContract> GetLoanCustomFieldWithHttpInfo (string customFieldId);
        /// <summary>
        /// Get all loan custom fields
        /// </summary>
        /// <remarks>
        /// Retrieves all loan custom fields under loan setup settings.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CustomFieldContract&gt;</returns>
        List<CustomFieldContract> GetLoanCustomFields ();

        /// <summary>
        /// Get all loan custom fields
        /// </summary>
        /// <remarks>
        /// Retrieves all loan custom fields under loan setup settings.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CustomFieldContract&gt;</returns>
        ApiResponse<List<CustomFieldContract>> GetLoanCustomFieldsWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get specific loan custom field
        /// </summary>
        /// <remarks>
        /// Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>Task of CustomFieldContract</returns>
        System.Threading.Tasks.Task<CustomFieldContract> GetLoanCustomFieldAsync (string customFieldId);

        /// <summary>
        /// Get specific loan custom field
        /// </summary>
        /// <remarks>
        /// Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>Task of ApiResponse (CustomFieldContract)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomFieldContract>> GetLoanCustomFieldAsyncWithHttpInfo (string customFieldId);
        /// <summary>
        /// Get all loan custom fields
        /// </summary>
        /// <remarks>
        /// Retrieves all loan custom fields under loan setup settings.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CustomFieldContract&gt;</returns>
        System.Threading.Tasks.Task<List<CustomFieldContract>> GetLoanCustomFieldsAsync ();

        /// <summary>
        /// Get all loan custom fields
        /// </summary>
        /// <remarks>
        /// Retrieves all loan custom fields under loan setup settings.
        /// </remarks>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CustomFieldContract&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<CustomFieldContract>>> GetLoanCustomFieldsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CustomFieldsApi : ICustomFieldsApi
    {
        private Elli.Api.Settings.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomFieldsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.Settings.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFieldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomFieldsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.Settings.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Elli.Api.Settings.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Get specific loan custom field Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>CustomFieldContract</returns>
        public CustomFieldContract GetLoanCustomField (string customFieldId)
        {
             ApiResponse<CustomFieldContract> localVarResponse = GetLoanCustomFieldWithHttpInfo(customFieldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get specific loan custom field Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>ApiResponse of CustomFieldContract</returns>
        public ApiResponse< CustomFieldContract > GetLoanCustomFieldWithHttpInfo (string customFieldId)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomFieldsApi->GetLoanCustomField");

            var localVarPath = "/encompass/v1/settings/loan/customFields/{customFieldId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (customFieldId != null) localVarPathParams.Add("customFieldId", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLoanCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CustomFieldContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFieldContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomFieldContract)));
        }

        /// <summary>
        /// Get specific loan custom field Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>Task of CustomFieldContract</returns>
        public async System.Threading.Tasks.Task<CustomFieldContract> GetLoanCustomFieldAsync (string customFieldId)
        {
             ApiResponse<CustomFieldContract> localVarResponse = await GetLoanCustomFieldAsyncWithHttpInfo(customFieldId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get specific loan custom field Retreives a specific loan custom field under loan setup settings based on custom field name passed.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="customFieldId">Loan custom field name</param>
        /// <returns>Task of ApiResponse (CustomFieldContract)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CustomFieldContract>> GetLoanCustomFieldAsyncWithHttpInfo (string customFieldId)
        {
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling CustomFieldsApi->GetLoanCustomField");

            var localVarPath = "/encompass/v1/settings/loan/customFields/{customFieldId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (customFieldId != null) localVarPathParams.Add("customFieldId", Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLoanCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CustomFieldContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CustomFieldContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CustomFieldContract)));
        }

        /// <summary>
        /// Get all loan custom fields Retrieves all loan custom fields under loan setup settings.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;CustomFieldContract&gt;</returns>
        public List<CustomFieldContract> GetLoanCustomFields ()
        {
             ApiResponse<List<CustomFieldContract>> localVarResponse = GetLoanCustomFieldsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all loan custom fields Retrieves all loan custom fields under loan setup settings.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;CustomFieldContract&gt;</returns>
        public ApiResponse< List<CustomFieldContract> > GetLoanCustomFieldsWithHttpInfo ()
        {

            var localVarPath = "/encompass/v1/settings/loan/customFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLoanCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CustomFieldContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomFieldContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomFieldContract>)));
        }

        /// <summary>
        /// Get all loan custom fields Retrieves all loan custom fields under loan setup settings.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;CustomFieldContract&gt;</returns>
        public async System.Threading.Tasks.Task<List<CustomFieldContract>> GetLoanCustomFieldsAsync ()
        {
             ApiResponse<List<CustomFieldContract>> localVarResponse = await GetLoanCustomFieldsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all loan custom fields Retrieves all loan custom fields under loan setup settings.
        /// </summary>
        /// <exception cref="Elli.Api.Settings.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;CustomFieldContract&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<CustomFieldContract>>> GetLoanCustomFieldsAsyncWithHttpInfo ()
        {

            var localVarPath = "/encompass/v1/settings/loan/customFields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetLoanCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<CustomFieldContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<CustomFieldContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<CustomFieldContract>)));
        }

    }
}
