using System.Xml;
using System;
using System.Xml.Serialization;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class BatchType {
        [XmlElement("TypeID")]
        public int TypeID { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
    }
}
