using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyEvernote.Entities
{
    [Table("Categories")]
    public class Category : MyEntitybase
    {
        [Required,StringLength(50)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }

        public virtual List<Note> Notes { get; set; }




    }
}
