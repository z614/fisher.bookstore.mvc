using Fisher.Bookstore.Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace Fisher.Bookstore.Api.Data.BookstoreContext
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
            {

            }
        
        protected override void OnModelCreating(ModelBuilder builder) => base
        .OnModelCreating(builder);
        public DbSet<Book> Books { get; set;}
       public DbSet<Author> Authors {get; set;}
        //AutoCorrection: using Models
    }
}