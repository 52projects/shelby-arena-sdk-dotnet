using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shelby.Api;

namespace Shelby.Api.People.QueryObject {
    public class PersonQO : BaseQO {
        public PersonQO() : base() {
        }

        public Shelby.Api.People.Enum.PersonSortField SortField { get; set; } = Enum.PersonSortField.FirstName;
    }
}
