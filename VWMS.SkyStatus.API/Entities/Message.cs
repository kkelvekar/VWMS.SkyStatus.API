using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VWMS.SkyStatus.API.Entities
{
    public class Message
    {
        [Key]
        [ForeignKey("StatusMessage")]
        public string ConversationID { get; set; }

        public string Realm { get; set; }
        public int Code { get; set; }
        public string LevelType { get; set; }
        public string ShortText { get; set; }
        public string LongText { get; set; }
        public DateTime MessageDateTime { get; set; }

        // Navigation property back to StatusMessage
        public virtual StatusMessage StatusMessage { get; set; }
    }
}
