using Shelby.Api.People.Entity;
using Shelby.Api.People.QueryObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;

namespace Shelby.Api.Tests.Giving.Funds {
    [TestClass]
    class ListTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_funds_list_all() {
            var results = this.ShelbyRestClient.Giving.Funds.FindAll(new Api.Giving.QueryObject.FundQO { });
            results.Count.ShouldBeGreaterThan(0);
        }
    }
}
