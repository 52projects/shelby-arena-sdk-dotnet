using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api;
using Shelby.Api.People.Entity;
using Shelby.Api.Entity;
using Shelby.Api.People.QueryObject;

namespace Shelby.Api.People.Sets {
    public class Person : ApiSet<Entity.Person> {
        public Person(RequestCredentials credentials) : base(credentials) {

        }

        public List<Entity.Person> FindAll(PersonQO qo) {
            return base.FindAll("person/list", qo);
        }
    }
}
