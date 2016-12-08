using System.Xml;
using System;
using System.Xml.Serialization;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class Batch {
        [XmlElement("BatchDate")]
        public DateTime BatchDate { get; set; }
        [XmlElement("BatchDateEnd")]
        public DateTime? BatchDateEnd { get; set; }
        [XmlElement("BatchId")]
        public int BatchId { get; set; }
        [XmlElement("BatchName")]
        public string BatchName { get; set; }
        [XmlElement("BatchTypeName")]
        public string BatchTypeName { get; set; }
        [XmlElement("Finalized")]
        public bool Finalized { get; set; }
        [XmlElement("Owner")]
        public string Owner { get; set; }
        [XmlElement("VerifyAmount")]
        public double VerifyAmount { get; set; }
    }
}
