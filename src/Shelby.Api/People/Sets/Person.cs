using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api;
using Shelby.Api.People.Entity;
using Shelby.Api.Entity;
using Shelby.Api.People.QueryObject;
using RestSharp;
using Shelby.Api.Model;

namespace Shelby.Api.People.Sets {
    public class Person : ApiSet<Entity.Person> {
        protected override string GetUrl { get { return "person/{0}"; } }
        protected override string EditUrl {get {return "person/{0}/update";}}
        protected override string CreateUrl { get { return "person/add"; } }
        public Person(RequestCredentials credentials) : base(credentials) {

        }

        public IShelbyResponse<List<Entity.Person>> FindAll(PersonQO qo) {
            return base.FindAll("person/list", qo);
        }

        public IShelbyResponse<Entity.Person> FindByID(int id) {
            return base.Get(id.ToString());
        }
    }
}
