using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api.Entity;
using Shouldly;

namespace Shelby.Api.Tests {
    public class BaseTest {
        internal RestClient ShelbyRestClient;

        [TestInitialize]
        public virtual void Setup() {
            this.ShelbyRestClient = new RestClient(
                                        this.GetConfigValue("Api.Url"),
                                        this.GetConfigValue("Api.Key"),
                                        this.GetConfigValue("Api.Secret"));
        }

        public ApiSession GetApiSession() {
            return this.ShelbyRestClient.GetApiSession(this.GetConfigValue("UserName"), this.GetConfigValue("Password"));
        }

        public string GetConfigValue(string key) {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }
    }
}
