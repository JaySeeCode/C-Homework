using Microsoft.EntityFrameworkCore;

namespace mvcTest.Models
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<mvcTest.Models.Book> Book { get; set; }
    }
}