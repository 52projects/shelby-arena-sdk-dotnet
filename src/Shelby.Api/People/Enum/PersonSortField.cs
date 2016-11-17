using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shelby.Api.People.Enum {
    public enum PersonSortField {
        [Description("FirstName")]
        FirstName,
        [Description("NickName")]
        NickName,
        [Description("LastName")]
        LastName,
        [Description("Address")]
        Address
    }
}
