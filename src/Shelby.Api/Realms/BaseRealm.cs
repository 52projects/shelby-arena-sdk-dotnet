using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api.Entity;

namespace Shelby.Api.Realms {
    public class BaseRealm {
        internal RequestCredentials _requestCredentials;
        public BaseRealm(RequestCredentials credentials) {
            this._requestCredentials = credentials;
        }
    }
}
