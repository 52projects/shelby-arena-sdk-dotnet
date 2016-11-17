using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Entity;

namespace Shelby.Api.Realms {
    public class PeopleRealm : BaseRealm {
        private Shelby.Api.People.Sets.Person _personSet;

        public PeopleRealm(RequestCredentials credentials) : base(credentials) {

        }

        #region Sets
        public Shelby.Api.People.Sets.Person Individuals {
            get {
                if (_personSet == null) {
                    _personSet = new People.Sets.Person(base._requestCredentials);
                }

                return _personSet;
            }
        }
        #endregion Sets
    }
}
