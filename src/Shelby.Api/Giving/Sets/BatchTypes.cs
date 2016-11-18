using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api;
using Shelby.Api.People.Entity;
using Shelby.Api.Entity;
using Shelby.Api.Giving.QueryObject;
using Shelby.Api.Giving.Entity;

namespace Shelby.Api.Giving.Sets {
    public class BatchTypes : ApiSet<BatchType> {
        public BatchTypes(RequestCredentials credentials) : base(credentials) {

        }

        public List<BatchType> FindAll() {
            return base.FindAll("batchtype/list");
        }
    }
}
