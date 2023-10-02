using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ChatUmadWeb.Data.Entities
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Apellido paterno")]
        public string FirstName { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Apellido materno")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(15, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Matrícula")]
        public string Enrollment { get; set; }

        [Display(Name = "Imagen")]
        public string? Image { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{LastName} {FirstName} {Name}";
    }
}
