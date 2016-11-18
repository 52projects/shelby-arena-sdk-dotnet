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


namespace Shelby.Api.Tests.People {
    [TestClass]
    public class CreateTests : BaseTest {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_people_create_person() {
            var person = new Person();
            person.FirstName = "integration";
            person.LastName = "test";

            var results = this.ShelbyRestClient.People.Individuals.Create(person);
        }
    }
}
