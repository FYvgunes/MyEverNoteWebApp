using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyEvernote.BussinesLayer
{
    public class test
    {
        public test()
        {
            DataAccessLayer.DatabaseContent db = new DataAccessLayer.DatabaseContent();

            db.evernoteUsers.ToList();
           
        }
    }
}
