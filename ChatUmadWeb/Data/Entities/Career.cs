namespace ChatUmadWeb.Data.Entities
{
    public class Career : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public ICollection<Student> Students { get; set; }

    }

}
