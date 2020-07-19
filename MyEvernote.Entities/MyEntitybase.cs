using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyEvernote.Entities
{
    public class MyEntitybase
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
      
        [Required]
        public DateTime CreateOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
        [Required]
        public string Modifiedusername { get; set; }

      

    }
}
