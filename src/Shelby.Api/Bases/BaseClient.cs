using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using RestSharp.Extensions.MonoHttp;
using Shelby.Api.Exceptions;
using Newtonsoft.Json.Linq;
using Shelby.Api.Entity;

namespace Shelby.Api {
    public class BaseClient {
        #region Properties
        public ContentType ContentType { get; set; }
        public string BaseUrl { get; set; }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public IDictionary<string, string> RequestHeaders { get; set; }

        #endregion Properties

        #region Constructor
        public BaseClient() {
        }

        public BaseClient(string baseUrl, string apiKey, string apiSecret) {
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
        }

        public BaseClient(IDictionary<string, string> requestHeaders, string baseUrl) {
            this.BaseUrl = BaseUrl;
            this.RequestHeaders = requestHeaders;
        }
        #endregion Constructor

        #region Methods
        public virtual ApiSession Auhtorize(string username, string password, string authorizeUrl) {
            var restClient = new RestSharp.RestClient(this.BaseUrl);

            var request = new RestRequest(authorizeUrl, Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("api_key", this.ApiKey);
            var response = restClient.Execute<ApiSession>(request);

            if (response.StatusCode != HttpStatusCode.OK) {
                throw new ApiAccessException(response.StatusDescription) {
                    StatusCode = response.StatusCode,
                    StatusDescription = response.StatusDescription,
                    RequestUrl = response.ResponseUri.AbsoluteUri
                };
            }
            else {
                return response.Data;
            }
        }
        #endregion Methods
    }

    public enum ContentType {
        XML = 1,
        JSON = 2
    }
}
