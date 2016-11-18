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
using Shelby.Api.Realms;

namespace Shelby.Api {
    public class RestClient {
        #region Properties
        public ContentType ContentType { get; set; }
        public string BaseUrl { get; set; }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public IDictionary<string, string> RequestHeaders { get; set; }

        public ApiSession ApiSession { get;  set;}

        private PeopleRealm _peopleRealm { get; set; }
        private GivingRealm _givingRealm { get; set; }


        public PeopleRealm People { get { return _peopleRealm; } }
        public GivingRealm Giving { get { return _givingRealm; } }

        #endregion Properties

        #region Constructor

        public RestClient(string baseUrl, string apiKey, string apiSecret, ApiSession session = null) {
            this.BaseUrl = baseUrl;
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
            this.ApiSession = session;

            if (session != null) {
                this.InitializeRealms();
            }
        }
        
        #endregion Constructor

        #region Methods
        public ApiSession GetApiSession(string username, string password) {
            var restClient = new RestSharp.RestClient(this.BaseUrl);

            var request = new RestRequest("login", Method.POST);
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
                this.ApiSession = response.Data;
                this.InitializeRealms();
                return ApiSession;
            }
        }

        private void InitializeRealms() {
            var credentials = new RequestCredentials {
                BaseUrl = this.BaseUrl,
                ApiSecret = this.ApiSecret,
                ApiKey = this.ApiKey,
                ApiSession = this.ApiSession
            };
            this._peopleRealm = new PeopleRealm(credentials);
            this._givingRealm = new GivingRealm(credentials);
        }
        #endregion Methods
    }
}
