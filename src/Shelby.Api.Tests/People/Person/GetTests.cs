using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shelby.Api;
using Shouldly;
using Shelby.Api.People.Entity;
using Shelby.Api.People.QueryObject;

namespace Shelby.Api.Tests.People {
    [TestClass]
    class GetTests : BaseTest {
        private int _personID = 16109;

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }

        [TestMethod]
        public void integration_people_get_person() {
            var result = this.ShelbyRestClient.People.Individuals.FindByID(_personID);
            result.PersonID.ShouldBe(_personID);
        }
    }
}