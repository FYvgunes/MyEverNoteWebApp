using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvernote.Entities
{
    public class Comment
    {
        public string text { get; set; }
        public virtual EvernoteUser Owner { get; set; }
        public virtual Note Note { get; set; }


    }
}
