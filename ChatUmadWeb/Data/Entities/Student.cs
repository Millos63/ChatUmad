namespace ChatUmadWeb.Data.Entities
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string? Image { get; set; }
        public Career Career { get; set; }
    }

}
