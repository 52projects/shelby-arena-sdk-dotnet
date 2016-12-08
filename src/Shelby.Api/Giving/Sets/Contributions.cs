using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Giving.Entity;
using Shelby.Api.Entity;
using Shelby.Api.Giving.QueryObject;

namespace Shelby.Api.Giving.Sets {
    public class Contributions : ApiSet<Contribution> {
        protected override string GetUrl { get { return "contribution/{0}"; } }
        protected override string EditUrl { get { return "contribution/{0}/update"; } }
        protected override string CreateUrl { get { return "contribution/add"; } }
        public Contributions(RequestCredentials credentials) : base(credentials) {

        }

        public List<Contribution> FindAll(ContributionQO qo) {
            return base.FindAll("contribution/list", qo);
        }

        public Contribution FindByID(int id) {
            return base.Get(id.ToString());
        }
    }
}