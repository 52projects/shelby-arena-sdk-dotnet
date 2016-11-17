using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shelby.Api.Entity {
    [XmlRoot("ApiSession")]
    public class ApiSession {
        [XmlElement("DateExpires")]
        public DateTime DateExpires { get; set; }

        [XmlElement("SessionID")]
        public string SessionID { get; set; }
    }
}
