using System.Xml;
using System;
using System.Xml.Serialization;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class Fund {
        [XmlElement("Active")]
        public bool Active { get; set; }
        [XmlElement("CanPledge")]
        public bool CanPledge { get; set; }
        [XmlElement("EndDate")]
        public DateTime? EndDate { get; set; }
        [XmlElement("FundDescription")]
        public string FundDescription { get; set; }
        [XmlElement("FundId")]
        public int FundId { get; set; }
        [XmlElement("FundName")]
        public string FundName { get; set; }
        [XmlElement("FundOrder")]
        public int FundOrder { get; set; }
        [XmlElement("OnlineName")]
        public string OnlineName { get; set; }
        [XmlElement("StartDate")]
        public DateTime StartDate { get; set; }
        [XmlElement("TaxDeductible")]
        public bool TaxDeductible { get; set; }
    }
}
