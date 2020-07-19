namespace MyEvernote.DataAccessLayer
{
    public class DbContext
    {
        public DbSet<MyEvernote> MyEvernotes { get; set; }
    }
}