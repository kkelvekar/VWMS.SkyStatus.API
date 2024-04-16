using System.ComponentModel.DataAnnotations;

namespace VWMS.SkyStatus.API.Entities
{
    public class StatusMessage
    {
        [Key]
        public string ConversationID { get; set; }
        public string AssetID { get; set; }
        public string ProviderID { get; set; }

        // Navigation properties
        public virtual Message Message { get; set; }
        public virtual ICollection<Reference> References { get; set; } = new List<Reference>();
    }
}
