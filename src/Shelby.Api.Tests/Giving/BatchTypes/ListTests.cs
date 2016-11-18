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

namespace Shelby.Api.Tests.Giving.BatchTypes {
    [TestClass]
    class ListTests : BaseTest {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_batch_types_list_types() {
            var results = this.ShelbyRestClient.Giving.BatchTypes.FindAll();
            results.Count.ShouldBeGreaterThan(0);
        }
    }
}
