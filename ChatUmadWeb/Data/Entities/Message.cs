using System.ComponentModel.DataAnnotations;

namespace ChatUmadWeb.Data.Entities
{
    public class Message : IEntity
    {
        public int Id { get; set; }
        public Chat Chat { get; set; }
        public User User { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public string MessageDescription { get; set; }
        public string? File { get; set; }
    }

}
