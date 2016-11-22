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
    public class Person {
        public Person() {
            this.Addresses = new List<Address>();
            this.Emails = new List<Email>();
            this.Phones = new List<Phone>();
        }

        [XmlElement("ActiveMeter")]
        public int ActiveMeter { get; set; }

        [XmlArrayItem("Address", typeof(Address))]
        [XmlArray("Addresses")]
        public List<Address> Addresses { get; set; }
        [XmlElement("Age")]
        public int Age { get; set; }

        [XmlElement("AnniversaryDate")]
        public DateTime? AnniversaryDate { get; set; }

        [XmlElement("AttributesLink")]
        public string AttributesLink { get; set; }

        [XmlElement("AreaName")]
        public string AreaName { get; set; }

        [XmlElement("BirthDate")]
        public DateTime? BirthDate { get; set; }

        [XmlElement("BlobID")]
        public int BlobID { get; set; }

        [XmlElement("BlobLink")]
        public string BlobLink { get; set; }

        [XmlElement("BusinessPhone")]
        public string BusinessPhone { get; set; }

        [XmlElement("CellPhone")]
        public string CellPhone { get; set; }

        [XmlElement("ContributeIndividually")]
        public bool ContributeIndividually { get; set; }

        [XmlElement("DateCreated")]
        public DateTime DateCreated { get; set; }

        [XmlElement("DateModified")]
        public DateTime DateModified { get; set; }

        [XmlElement("DisplayNotesCount")]
        public int DisplayNotesCount { get; set; }

        [XmlElement("EmailStatement")]
        public bool EmailStatement { get; set; }

        [XmlArrayItem("Email", typeof(Email))]
        [XmlArray("Emails")]
        public List<Email> Emails { get; set; }

        [XmlElement("EnvelopeNumber")]
        public int EnvelopeNumber { get; set; }

        [XmlElement("FamilyID")]
        public int FamilyID { get; set; }

        [XmlElement("FamilyLink")]
        public string FamilyLink { get; set; }

        [XmlElement("FamilyMemberRoleID")]
        public int FamilyMemberRoleID { get; set; }

        [XmlElement("FamilyMemberRoleValue")]
        public string FamilyMemberRoleValue { get; set; }

        [XmlElement("FamilyMembersCount")]
        public int FamilyMembersCount {get; set; }

        [XmlElement("FamilyName")]
        public string FamilyName { get; set; }

        [XmlElement("FirstActiveEmail")]
        public string FirstActiveEmail { get; set; }

        [XmlElement("FirstName")]
        public string FirstName { get; set; }

        [XmlElement("Gender")]
        public string Gender { get; set; }

        [XmlElement("HomePhone")]
        public string HomePhone { get; set; }

        [XmlElement("LastName")]
        public string LastName { get; set; }

        [XmlElement("MemberStatusID")]
        public int MemberStatusID { get; set; }

        [XmlElement("MemberStatusValue")]
        public string MemberStatusValue { get; set; }

        [XmlElement("NickName")]
        public string NickName { get; set; }

        [XmlElement("PersonGUID")]
        public string PersonGUID { get; set; }

        [XmlElement("PersonID")]
        public int PersonID { get; set; }

        [XmlElement("PersonLink")]
        public string PersonLink { get; set; }

        [XmlArrayItem("Phone", typeof(Phone))]
        [XmlArray("Phones")]
        public List<Phone> Phones { get; set; }

        [XmlElement("RecordStatusValue")]
        public string RecordStatusValue { get; set; }

        [XmlElement("PrintStatement")]
        public bool PrintStatement { get; set; }

        [XmlElement("RecordStatusID")]
        public int RecordStatusID { get; set; }

        [XmlElement("RegionName")]
        public string RegionName { get; set; }

        [XmlElement("SuffixID")]
        public int SuffixID { get; set; }

        [XmlElement("SuffixValue")]
        public string SuffixValue { get; set; }

        [XmlElement("TitleID")]
        public int TitleID { get; set; }

        [XmlElement("TitleValue")]
        public string TitleValue { get; set; }
    }
}
