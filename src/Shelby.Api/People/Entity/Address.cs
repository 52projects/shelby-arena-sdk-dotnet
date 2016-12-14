using System.Xml;
using System;
using System.Xml.Serialization;

namespace Shelby.Api.People.Entity {
    [Serializable]
    public class Address {
        [XmlElement("AddressID")]
        public int AddressID { get; set; }
        [XmlElement("AddressTypeID")]
        public int AddressTypeID { get; set; }
        [XmlElement("AddressTypeValue")]
        public string AddressTypeValue { get; set; }
        [XmlElement("City")]
        public string City { get; set; }
        [XmlElement("Country")]
        public string Country { get; set; }
        [XmlElement("PostalCode")]
        public string PostalCode { get; set; }
        [XmlElement("Primary")]
        public bool Primary { get; set; }
        [XmlElement("State")]
        public string State { get; set; }
        [XmlElement("StreeLine1")]
        public string StreetLine1 { get; set; }
        [XmlElement("StreeLine2")]
        public string StreetLine2 { get; set; }
    }
}
