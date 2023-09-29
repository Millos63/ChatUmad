using System.ComponentModel.DataAnnotations;

namespace ChatUmadWeb.Data.Entities
{
    public class Chat : IEntity
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public ChatType ChatType { get; set; }
        public ICollection<ChatMember> ChatMembers { get; set;}
        public ICollection<Message> Messages { get; set;}
    }

}
