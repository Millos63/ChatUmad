﻿using System.ComponentModel.DataAnnotations;

namespace ChatUmadWeb.Data.Entities
{
    public class Chat : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es obligatorio.")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Fecha creación")]
        public DateTime Date { get; set; }
        public ChatType ChatType { get; set; }
        public ICollection<ChatMember> ChatMembers { get; set;}
        public ICollection<Message> Messages { get; set;}
    }

}
