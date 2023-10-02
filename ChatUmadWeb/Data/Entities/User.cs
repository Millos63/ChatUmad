using Microsoft.AspNetCore.Identity;

namespace ChatUmadWeb.Data.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Enrollment { get; set; }
        
    }
}
