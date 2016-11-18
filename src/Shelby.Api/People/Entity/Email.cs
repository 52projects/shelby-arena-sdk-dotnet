using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Shelby.Api.Model;

namespace Shelby.Api.People.Entity {
    [Serializable]
    public class Email {
        [XmlElement("Address")]
        public string Address { get; set; }
    }
}
