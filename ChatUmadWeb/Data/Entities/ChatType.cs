﻿using System.ComponentModel.DataAnnotations;

namespace ChatUmadWeb.Data.Entities
{
    public class ChatType: IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [MaxLength(200, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres.")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        public ICollection<Chat> Chats { get; set;}
    }
}
