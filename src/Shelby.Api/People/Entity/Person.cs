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
        [XmlElement("Age")]
        public int Age { get; set; }

        [XmlElement("AreaName")]
        public string AreaName { get; set; }

        [XmlElement("BirthDate")]
        public DateTime? BirthDate { get; set; }

        [XmlElement("BlobLink")]
        public string BlobLink { get; set; }

        [XmlElement("BusinessPhone")]
        public string BusinessPhone { get; set; }

        [XmlElement("FamilyID")]
        public int FamilyID { get; set; }

        [XmlElement("FamilyMemberRoleID")]
        public int FamilyMemberRoleID { get; set; }

        [XmlElement("FamilyMemberRoleValue")]
        public string FamilyMemberRoleValue { get; set; }

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

        [XmlElement("RecordStatusValue")]
        public string RecordStatusValue { get; set; }

    }
}
