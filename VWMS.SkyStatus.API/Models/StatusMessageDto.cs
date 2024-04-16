using System.Xml.Serialization;

namespace VWMS.SkyStatus.API.Models
{
    [XmlRoot(ElementName = "StatusMessage", Namespace = "URN:NNDS:VAM:STATUS")]
    public class StatusMessageDto
    {
        [XmlAttribute(AttributeName = "conversationID")]
        public string ConversationID { get; set; }

        [XmlAttribute(AttributeName = "assetID")]
        public string AssetID { get; set; }

        [XmlAttribute(AttributeName = "providerID")]
        public string ProviderID { get; set; }

        [XmlElement(ElementName = "message")]
        public MessageDto Message { get; set; }

        [XmlArray(ElementName = "references")]
        [XmlArrayItem(ElementName = "reference")]
        public List<ReferenceDto> References { get; set; }
    }

}
