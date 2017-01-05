using System.Xml;
using System;
using System.Xml.Serialization;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class ContributionFund {
        public ContributionFund() {
            this.Fund = new Fund();
        }
        [XmlElement("Amount")]
        public decimal Amount { get; set; }
        [XmlElement("ContributionFundId")]
        public int ContributionFundId { get; set; }
        [XmlElement("ContributionId")]
        public int ContributionId { get; set; }
        [XmlElement("Fund")]
        public Fund Fund { get; set; }
        [XmlElement("FundId")]
        public int FundId { get; set; }
        [XmlElement("ProjectId")]
        public int? ProjectId { get; set; }
    }
}
