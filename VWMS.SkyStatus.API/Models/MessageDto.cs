using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using VWMS.SkyStatus.API.Entities;

namespace VWMS.SkyStatus.API.Models
{
    public class MessageDto
    {
        [XmlElement(ElementName = "realm")]
        public string Realm { get; set; }

        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "levelType")]
        public string LevelType { get; set; }

        [XmlElement(ElementName = "shortText")]
        public string ShortText { get; set; }

        [XmlElement(ElementName = "longText")]
        public string LongText { get; set; }

        [XmlElement(ElementName = "messageDateTime")]
        public DateTime MessageDateTime { get; set; }
    }

}
