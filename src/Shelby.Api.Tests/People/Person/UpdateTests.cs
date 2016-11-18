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
    public class UpdateTests : BaseTest {

        [TestInitialize]
        public override void Setup() {
            base.Setup();
            this.ShelbyRestClient.ApiSession = base.GetApiSession();
        }
        [TestMethod]
        public void integration_people_list_get_people() {
            var qo = new PersonQO();
            qo.AddSearchByFeild("FirstName", "chad");
            qo.AddSearchByFeild("LastName", "meyer");

            var results = this.ShelbyRestClient.People.Individuals.FindAll(qo);
        }
    }
}
