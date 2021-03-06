﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyEvernote.Entities
{
    [Table("Evernoteuser")]
    public class EvernoteUser : MyEntitybase
    {
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Surname { get; set; }

        [Required, StringLength(25)]
        public string UserName { get; set; }

        [Required, StringLength(70)]
        public string Email { get; set; }


        [Required, StringLength(25)]
        public string Password { get; set; }
        [Required]
        public Guid AvtiveGuid { get; set; }

        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        public virtual List<Note> Notes { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likeds { get; set; }



    }
}
