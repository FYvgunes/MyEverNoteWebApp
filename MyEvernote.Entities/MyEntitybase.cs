using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvernote.Entities
{
    public class MyEntitybase
    {

        public int ID { get; set; }
      

        public DateTime CreateOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string Modifiedusername { get; set; }

        public virtual List<Comment> Notes { get; set; }
        public virtual Category Category { get; set; }
        public virtual EvernoteUser OwNot { get; set; }

    }
}
