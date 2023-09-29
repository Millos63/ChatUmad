namespace ChatUmadWeb.Data.Entities
{
    public class ChatType: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Chat> Chats { get; set;}
    }
}
