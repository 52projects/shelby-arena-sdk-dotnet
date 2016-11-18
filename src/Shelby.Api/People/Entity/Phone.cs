using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelby.Api.People.Entity {
    public class Phone {
        public string Extenstion { get; set; }
        public string Number { get; set; }
        public int PhoneTypeID { get; set; }

        public string PhoneTypeValue { get; set; }

        public bool SMSEnabled { get; set; }

        public bool Unlisted { get; set; }
    }
}
