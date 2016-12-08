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

namespace Shelby.Api.Tests.Giving.Batches {
    [TestClass]
    class AddTests : ContributionBase {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_giving_batches_create_batch() {
            var batch = new Shelby.Api.Giving.Entity.Batch {
                BatchDate = DateTime.UtcNow,
                BatchDateEnd = DateTime.UtcNow.AddDays(1),
                BatchName = "Testing API",
                BatchTypeName = "Unknown",
                Finalized = false
            };
            var results = this.ShelbyRestClient.Giving.Batches.Create(batch);
        }
    }
}
