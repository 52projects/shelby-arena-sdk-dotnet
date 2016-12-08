using System.Xml;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class PersonInformation {
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        [XmlElement("LastName")]
        public string LastName { get; set; }
        [XmlElement("NickName")]
        public string NickName { get; set; }
    }
}
