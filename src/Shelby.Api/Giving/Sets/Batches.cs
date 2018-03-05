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
    public class Batches : ApiSet<Batch> {
        protected override string GetUrl { get { return "batch/{0}"; } }
        protected override string EditUrl { get { return "batch/{0}/update"; } }
        protected override string CreateUrl { get { return "batch/add"; } }
        public Batches(RequestCredentials credentials) : base(credentials) {

        }

        public IShelbyResponse<List<Batch>> FindAll(BatchQO qo) {
            return base.FindAll("batch/list", qo);
        }

        public IShelbyResponse<Batch> FindByID(int id) {
            return base.Get(id.ToString());
        }
    }
}