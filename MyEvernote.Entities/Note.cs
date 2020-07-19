 using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvernote.Entities
{
    public class Note:MyEntitybase
    {
        public string Title { get; set; }
        public string text { get; set; }
        public bool IsDaraf { get; set; }
        public int LikeCount { get; set; }
        public int CategoriID { get; set; }


        public virtual EvernoteUser Ownot { get; set; }
        public virtual List<Note> Notes { get; set; }

    }
}
