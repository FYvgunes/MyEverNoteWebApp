using System;
using System.Collections.Generic;
using System.Text;

namespace MyEvernote.Entities
{
    public class Liked
    {
        public int ID { get; set; }
        public virtual Note Note { get; set; }
        public virtual EvernoteUser LikeUser { get; set; }




    }
}
