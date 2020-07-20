using MyEvernote.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MyEvernote.DataAccessLayer
{
    public class DatabaseContent : DbContext
    {
        public DbSet<EvernoteUser> evernoteUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Liked> Likes { get; set; }
        public DbSet<Category> categories { get; set; }



    }
}
