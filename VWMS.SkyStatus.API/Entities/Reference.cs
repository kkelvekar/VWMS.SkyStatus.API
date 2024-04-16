using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VWMS.SkyStatus.API.Entities
{
    public class Reference
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReferenceID { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceName { get; set; }
        public string ID { get; set; }

        // Foreign key
        public string ConversationID { get; set; }

        // Navigation property back to StatusMessage
        [ForeignKey("ConversationID")]
        public virtual StatusMessage StatusMessage { get; set; }
    }
}
