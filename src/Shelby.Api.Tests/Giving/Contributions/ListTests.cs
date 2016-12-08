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

namespace Shelby.Api.Tests.Giving.Contributions {
    [TestClass]
    class ListTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_contirubtions_list_all() {
            var results = this.ShelbyRestClient.Giving.Contributions.FindAll(new Api.Giving.QueryObject.ContributionQO { });
            results.Count.ShouldBeGreaterThan(0);
        }

        [TestMethod]
        public void integration_giving_contirubtions_list_filter_date() {
            var qo = new Api.Giving.QueryObject.ContributionQO();
            qo.SearchByFields.Add("fromDate", "2016-12-6");
            qo.SearchByFields.Add("toDate", "2016-12-7");
            var results = this.ShelbyRestClient.Giving.Contributions.FindAll(qo);
            results.Count.ShouldBeGreaterThan(0);
        }
    }
}
