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

namespace Shelby.Api.Tests.Giving.Funds {
    [TestClass]
    class GetTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        [ExpectedException(typeof(ApiAccessException))]
        public void integration_giving_funds_get() {
            var result = this.ShelbyRestClient.Giving.Funds.Get("1");
            result.ShouldNotBe(null);
        }
    }
}
