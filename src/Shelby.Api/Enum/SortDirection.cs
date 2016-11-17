using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shelby.Api.Enum {
    public enum SortDirection {
        [Description("ASC")]
        ASC,
        [Description("DESC")]
        DESC
    }
}
