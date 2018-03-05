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
using Shelby.Api.Exceptions;

namespace Shelby.Api.Tests.Giving.Contributions {
    [TestClass]
    public class UpdateTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_contribution_update_batch() {
            var response = this.ShelbyRestClient.Giving.Contributions.Get("1690033");
            var result = response.Data;
            result.BatchId = 24200;
            var updateResult = this.ShelbyRestClient.Giving.Contributions.Update(result, result.ContributionId.ToString());
            result.ShouldNotBe(null);
        }
    }
}