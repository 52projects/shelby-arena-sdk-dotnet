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
        private Giving.Sets.Funds _fundsSet;
        private Giving.Sets.Contributions _contributionsSet;

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

        public Shelby.Api.Giving.Sets.Funds Funds {
            get {
                if (_fundsSet == null) {
                    _fundsSet = new Giving.Sets.Funds(base._requestCredentials);
                }

                return _fundsSet;
            }
        }

        public Shelby.Api.Giving.Sets.Contributions Contributions {
            get {
                if (_contributionsSet == null) {
                    _contributionsSet = new Giving.Sets.Contributions(base._requestCredentials);
                }

                return _contributionsSet;
            }
        }
        #endregion Sets
    }
}
