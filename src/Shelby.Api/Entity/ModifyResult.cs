using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Shelby.Api.Entity {
    [Serializable]
    public class ModifyResult {
        [XmlElement("ErrorMessage")]
        public string ErrorMessage { get; set; }
        [XmlElement("Successful")]
        public bool Successful { get; set; }

        [XmlElement("Link")]
        public string Link { get; set; }

        [XmlElement("ObjectID")]
        public string ObjectID { get; set; }
    }
}
