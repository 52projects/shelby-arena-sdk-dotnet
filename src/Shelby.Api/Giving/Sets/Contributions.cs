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
        private string _createUrl = string.Empty;
        protected override string GetUrl { get { return "contribution/{0}"; } }
        protected override string EditUrl { get { return "contribution/{0}/update"; } }
        protected override string CreateUrl { get { return _createUrl; } }
        public Contributions(RequestCredentials credentials) : base(credentials) {

        }

        public List<Contribution> FindAll(ContributionQO qo) {
            return base.FindAll("contribution/list", qo);
        }

        public Contribution FindByID(int id) {
            return base.Get(id.ToString());
        }

        public ModifyResult Create(int batchID, Contribution entity) {
            var requestXml = string.Empty;
            this._createUrl = $"batch/{batchID}/contribution/add";
            return base.Create(entity, out requestXml);
        }
    }
}