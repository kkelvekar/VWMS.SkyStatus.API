using System.Xml.Serialization;

namespace VWMS.SkyStatus.API.Models
{
    public class ReferenceDto
    {
        [XmlElement(ElementName = "referenceType")]
        public string ReferenceType { get; set; }

        [XmlElement(ElementName = "referenceName")]
        public string ReferenceName { get; set; }

        [XmlElement(ElementName = "referenceID")]
        public string ID { get; set; }
    }

}
