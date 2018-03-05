using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Giving.Entity;
using Shelby.Api.Entity;
using Shelby.Api.Giving.QueryObject;
using Shelby.Api.Model;

namespace Shelby.Api.Giving.Sets {
    public class Funds : ApiSet<Fund> {
        protected override string GetUrl { get { return "fund/{0}"; } }
        protected override string EditUrl { get { return "fund/{0}/update"; } }
        protected override string CreateUrl { get { return "fund/add"; } }
        public Funds(RequestCredentials credentials) : base(credentials) {

        }

        public IShelbyResponse<List<Fund>> FindAll(FundQO qo) {
            return base.FindAll("fund/list", qo);
        }

        public IShelbyResponse<Fund> FindByID(int id) {
            return base.Get(id.ToString());
        }
    }
}