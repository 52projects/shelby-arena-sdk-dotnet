using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelby.Api.Tests.Giving {
    public class ContributionBase : BaseTest {
        public override void Setup() {
            this.ShelbyRestClient = new RestClient(
                            this.GetConfigValue("Api.Url"),
                            this.GetConfigValue("Contribution.Api.Key"),
                            this.GetConfigValue("Contribution.Api.Secret"));
        }
    }
}
