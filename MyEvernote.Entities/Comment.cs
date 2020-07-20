using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyEvernote.Entities
{
    [Table("Commets")]
    public class Comment:MyEntitybase
    { 
    
        [Required,StringLength(250)]
        public string text { get; set; }
        public virtual EvernoteUser Owner { get; set; }
        public virtual Note Note { get; set; }


    }
}
