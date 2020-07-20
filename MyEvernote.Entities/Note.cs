 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyEvernote.Entities
{
    [Table("Notes")]
    public class Note : MyEntitybase
{
    [Required,StringLength(60)] 
        public string Title { get; set; }
    [Required,StringLength(2000)]
        public string text { get; set; }
        public bool IsDaraf { get; set; }
        public int LikeCount { get; set; }
        public int CategoriID { get; set; }


        public virtual EvernoteUser Ownot { get; set; }
        public virtual List<Note> Notes { get; set; }

    }
}
