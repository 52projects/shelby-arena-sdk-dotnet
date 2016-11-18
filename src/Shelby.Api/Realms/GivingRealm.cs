using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Entity;

namespace Shelby.Api.Realms {
    public class GivingRealm : BaseRealm {
        private Giving.Sets.BatchTypes _batchTypesSet;
        private Giving.Sets.Batches _batchesSet;

        public GivingRealm(RequestCredentials credentials) : base(credentials) {

        }

        #region Sets
        public Shelby.Api.Giving.Sets.BatchTypes BatchTypes {
            get {
                if (_batchTypesSet == null) {
                    _batchTypesSet = new Giving.Sets.BatchTypes(base._requestCredentials);
                }

                return _batchTypesSet;
            }
        }

        public Shelby.Api.Giving.Sets.Batches Batches {
            get {
                if (_batchesSet == null) {
                    _batchesSet = new Giving.Sets.Batches(base._requestCredentials);
                }

                return _batchesSet;
            }
        }
        #endregion Sets
    }
}
