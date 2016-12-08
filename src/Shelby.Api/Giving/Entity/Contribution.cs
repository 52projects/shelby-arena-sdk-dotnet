using System.Xml;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Shelby.Api.Giving.Entity {
    [Serializable]
    public class Contribution {
        public Contribution() {
            this.ContributionFunds = new List<ContributionFund>();
            this.PersonInformation = new PersonInformation();
        }
        [XmlElement("BatchId")]
        public int BatchId { get; set; }
        [XmlElement("BatchLink")]
        public string BatchLink { get; set; }
        [XmlElement("ContributionDate")]
        public DateTime ContributionDate { get; set; }
        [XmlArrayItem("ContributionFund", typeof(ContributionFund))]
        [XmlArray("ContributionFunds")]
        public List<ContributionFund> ContributionFunds { get; set; }
        [XmlElement("ContributionId")]
        public int ContributionId { get; set; }
        [XmlElement("CurrencyAmount")]
        public decimal CurrencyAmount { get; set; }
        [XmlElement("CurrencyTypeId")]
        public int CurrencyTypeId { get; set; }
        [XmlElement("CurrencyTypeValue")]
        public string CurrencyTypeValue { get; set; }
        [XmlElement("ImageEnvelopeLink")]
        public string ImageEnvelopeLink { get; set; }
        [XmlElement("Memo")]
        public string Memo { get; set; }
        [XmlElement("PersonId")]
        public int PersonId { get; set; }
        [XmlElement("PersonInformation")]
        public PersonInformation PersonInformation { get; set; }
        [XmlElement("PersonLink")]
        public string PersonLink { get; set; }
        [XmlElement("RefundContributionId")]
        public int RefundContributionId { get; set; }
        [XmlElement("TrasnactionNumber")]
        public string TrasnactionNumber { get; set; }
    }
}